using System;


namespace UOM.Quantities
{
    public partial class Quantity: IQuantity
    { 
        public IQuantityType Type{
            get; private set;
        }        
        public IQuantity Multiply(IQuantity quntity){
            throw new NotImplementedException("Quntity.Multiply");
        }

        public IQuantity Divide(IQuantity quntity){
            throw new NotImplementedException("Quntity.Divide");
        }

        public IQuantity Inverse(){
            throw new NotImplementedException("Quntity.Inverse");
        }

        private Quantity(){}
        private Quantity(string quantityName){
            throw new NotImplementedException("Quantity.Quantity(quantityName)");
        }
    
    }

    
}
