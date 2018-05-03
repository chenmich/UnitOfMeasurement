using System;

namespace UOM.Quantities
{
    public class Length:Quantity{
        public Length(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Length");
        }
    }
}