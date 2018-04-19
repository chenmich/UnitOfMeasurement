using System;

namespace UOM.Quantities
{
    public class QuantityType:IQuantityType
    {
        public IQuantityType Multiply(IQuantityType quntityType){
            throw new NotImplementedException("quntityType.Multiply");
        }
        public IQuantityType Divide(IQuantityType quntityType){
            throw new NotImplementedException("QuntityType.Divide");
        }
        public IQuantityType Inverse(){
            throw new NotImplementedException("QuntityType.Inserve");
        }
    }
}
