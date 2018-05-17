using System;
using UOM.Units;
using UOM.UOMException;


namespace UOM.Quantities
{
    public  class Quantity: IQuantity
    { 
        private IUnit _unit;
        private IQuantityType _type;
        public IUnit Unit{             
            internal set{
                if(_type.Equals(null)){
                    _type = value.Sys.QType;
                    _unit = value;
                }else{
                    if(_type.Equals(value.Sys.QType))
                        _unit = value;
                    else{
                        string message = "The type of Qunatity is not matched by " + value.UnitName;
                        throw new NotMatchedBetweenQuantityTypeAndUnitException(message); 
                    }
                }
                    
            }
            get{
                return _unit;
            }
        }
        public  IQuantityType Type{
            get{
                return _type;
            }
             internal set{
                 _type = value;
                 _unit = _type.Sys.Primary;
             }
        }
        public float Value{
            get; internal set;
        }
        private Quantity getQuantity(TypeExpression exp){
            QuantityTypeService service = QuantityTypeService.getService();
            QuantityType _type = service.getType(exp) as QuantityType;
            Quantity quantity = _type.getQuantity() as Quantity;
            quantity.Type = _type;
            return quantity;
        }       
        public virtual IQuantity Multiply(IQuantity right){
            TypeExpression _Exp = new TypeExpression(this.Type, right.Type, TypeOperator.Multiply);
            IQuantity quantity = getQuantity(_Exp) as IQuantity;
            return quantity;
        }

        public virtual IQuantity Divide(IQuantity right){
            TypeExpression _Exp = new TypeExpression(this.Type, right.Type, TypeOperator.Divide);
            IQuantity quantity = getQuantity(_Exp) as IQuantity;
            return quantity;
        }

        public virtual IQuantity Add(IQuantity right){
            if (!Type.Equals(right.Type)){
                string message = "Added by the Quantity " + right.Type.Id.Name;
                throw new  NotSameQuantityForAddOrSubstractException(message);
            }
            QuantityType _type = Type as QuantityType;
            return _type.getQuantity();
        }

        public virtual IQuantity Substract(IQuantity right){
            if(!Type.Equals(right.Type)){
                string message = "Substract by the Quantity " + right.Type.Id.Name;
                throw new NotSameQuantityForAddOrSubstractException(message);
            }
            QuantityType _type = Type as QuantityType;
            return _type.getQuantity();
        }

        

        public IQuantity toUnit(IUnit unit){
            if(!Type.Equals(unit.Sys.QType)){
                string message = "Cann't convert to the Quantity " + unit.Sys.QType.Id.Name + "'unit!";
                throw new NotMatchedBetweenQuantityTypeAndUnitException(message);
            }
            float toPrimaryValue = Unit.toPrimary(Value);
            float fromPrimaryValue = unit.fromPrimary(toPrimaryValue);
            QuantityType _type = Type as QuantityType;
            Quantity result = _type.getQuantity() as Quantity;
            result.Unit = unit;
            result.Value = fromPrimaryValue;
            return result as IQuantity;
        }

        public Quantity(){}

        public Quantity(IQuantityType type, IUnit unit):this(type, unit, 0){
            
        }
        public Quantity(IQuantityType type, IUnit unit, float value){
            Type = type;
            Unit = unit;
            Value = value;
        }

    }

    
}
