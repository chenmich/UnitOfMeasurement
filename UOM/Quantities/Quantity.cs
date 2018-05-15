using System;
using UOM.Units;
using UOM.UOMException;

namespace UOM.Quantities
{
    public  class Quantity: IQuantity
    { 
        public IUnit Unit{
            get; internal set;
        }
        public  IQuantityType Type{
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

        public float Value{
            get; internal set;
        }

        public IQuantity toUnit(IUnit unit){
            if(!Type.Equals(unit.Sys.QType)){
                string message = "Cann't convert to the Quantity " + unit.Sys.QType.Id.Name + "'unit!";
                throw new CannotConvertToUnitException(message);
            }
            
        }

        public Quantity(){}
        public Quantity(float value){
            Value = value;
        }  
    }

    
}
