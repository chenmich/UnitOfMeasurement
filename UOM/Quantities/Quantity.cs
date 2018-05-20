using System;
using UOM.Units;
using UOM.UOMException;


namespace UOM.Quantities
{
    public  class Quantity: IQuantity
    { 
        public IUnit Unit{             
            get;
            internal set;
            
        }
        public  IQuantityType Type{
            get;
            internal set;
        }
        public float Value{
            get; internal set;
        }
        
        public virtual IQuantity Multiply(IQuantity right){
            IQuantityType qtype = Type.Multiply(right.Type);
            if(qtype.Equals(null)) throw new QuantityTypeNotExistedException("Quantity.Multiplyy");
            Quantity quantity = qtype.getQuantity() as Quantity;
            float left_value_byPrimary = Unit.Converter.toPrimary(Value);
            float right_value_byPrimary = right.Unit.Converter.toPrimary(right.Value);
            float value = left_value_byPrimary * right_value_byPrimary; 
            quantity.Value = value;
            return quantity;
        }

        public virtual IQuantity Divide(IQuantity right){
            IQuantityType qtype = Type.Divide(right.Type);
            if(qtype.Equals(null)) throw new QuantityTypeNotExistedException("Quantity.Divide");
            Quantity quantity = qtype.getQuantity() as Quantity;
            float left_value_byPrimary = Unit.Converter.toPrimary(Value);
            float right_value_byPrimary = right.Unit.Converter.toPrimary(right.Value);
            float value = left_value_byPrimary / right_value_byPrimary;
            quantity.Value = value;            
            return quantity;
        }

        public virtual IQuantity Add(IQuantity right){
            if (!Type.Equals(right.Type)){
                string message = "Added by the Quantity " + right.Type.Id.Name;
                throw new  NotSameQuantityForAddOrSubstractException(message);
            }
            QuantityType _type = Type as QuantityType;
            float left_value_byPrimary = Unit.Converter.toPrimary(Value);
            float right_value_byPrimary = right.Unit.Converter.toPrimary(right.Value);
            float value = left_value_byPrimary + right_value_byPrimary;
            Quantity quantity = _type.getQuantity() as Quantity;
            quantity.Value = value;
            return quantity;
        }

        public virtual IQuantity Substract(IQuantity right){
            if(!Type.Equals(right.Type)){
                string message = "Substract by the Quantity " + right.Type.Id.Name;
                throw new NotSameQuantityForAddOrSubstractException(message);
            }
            QuantityType _type = Type as QuantityType;
            float left_value_byPrimary = Unit.Converter.toPrimary(Value);
            float right_value_byPrimary = right.Unit.Converter.toPrimary(right.Value);
            float value = left_value_byPrimary - right_value_byPrimary;
            Quantity quantity = _type.getQuantity() as Quantity;
            quantity.Value = value;
            return quantity;
        }       

        public IQuantity toUnit(IUnit unit){
            if(!Type.Equals(unit.Sys.QType)){
                string message = "Cann't convert to the Quantity " + unit.Sys.QType.Id.Name + "'unit!";
                throw new NotMatchedBetweenQuantityTypeAndUnitException(message);
            }
            float toPrimaryValue = Unit.Converter.toPrimary(Value);
            float fromPrimaryValue = unit.Converter.fromPrimary(toPrimaryValue);
            Quantity result =Type.getQuantity() as Quantity;
            result.Unit = unit;
            result.Value = fromPrimaryValue;
            return result as IQuantity;
        }

        internal Quantity(){}

        public Quantity(IUnit unit):this(unit,  0){
            
        }
        public Quantity(IUnit unit, float value){
            Type = unit.Sys.QType;
            Unit = unit;
            Value = value;
        }
    
    }

    
}
