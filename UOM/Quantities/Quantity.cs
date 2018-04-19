using System;


namespace UOM.Quantities
{
    public class Quantity<T>: IQuantity<T>
    { 
        public IQuantityType Type{
            get; private set;
        }        
        public IQuantity<T> Multiply(IQuantity<T> quntity){
            throw new NotImplementedException("Quntity.Multiply");
        }

        public IQuantity<T> Divide(IQuantity<T> quntity){
            throw new NotImplementedException("Quntity.Divide");
        }

        public IQuantity<T> Inverse(){
            throw new NotImplementedException("Quntity.Inverse");
        }

        public Quantity(IQuantityType type){
            Type = type;
        }
    }

    
}
