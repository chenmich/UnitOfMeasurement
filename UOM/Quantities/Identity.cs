using System;

namespace UOM.Quantities
{
    public class Identity: IQuantity
    {
        public IQuantityType Type{
            get; internal set;
        }
        public IQuantity Multiply(IQuantity right){
            throw new NotImplementedException("Identity.Multiply");
        }
        public IQuantity Divide(IQuantity right){
            throw new NotImplementedException("Identity.Divide");
        }
        public IQuantity Inverse(){
            throw new NotImplementedException("Identity.Inserve");
        }
        public Identity(){
            QuantityTypeService service = QuantityTypeService.getService();            
            IQuantityType type = service.getType("Identity");
            Type = type;
        }
    }
}
