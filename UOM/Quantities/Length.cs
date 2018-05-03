using System;

namespace UOM.Quantities
{
    public class Length:IQuantity{
        public IQuantityType Type{
            get; private set;
        }

        public IQuantity Multiply(IQuantity right){
            throw new NotImplementedException("Length.Multiply");
        }
        public IQuantity Divide(IQuantity right){
            throw new NotImplementedException("Length.Divide");
        }

        public IQuantity Inverse(){
            throw new NotImplementedException("Length.Inverse");
        }

        public Length(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Length");
        }
    }
}