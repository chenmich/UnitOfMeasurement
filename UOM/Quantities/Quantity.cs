using System;


namespace UOM.Quantities
{
    public  class Quantity: IQuantity
    { 
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

        public Quantity(){}    
    }

    
}
