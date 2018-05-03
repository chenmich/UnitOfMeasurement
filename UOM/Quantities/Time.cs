using System;

namespace UOM.Quantities
{
    public class Time:IQuantity
    {
        public IQuantityType Type{
            get; private set;
        }

        public IQuantity Multiply(IQuantity right){
            throw new NotImplementedException("Time.Multiply");
        }

        public IQuantity Divide(IQuantity right){
            throw new NotImplementedException("Time.Divide");
        }

        public IQuantity Inverse(){
            throw new NotImplementedException("Time.Inverse");
        }

        public Time(){}
        internal Time(IQuantityType type){
            Type = type;
        }
    }
}
