using System;
using UOM.Units;

namespace UOM.Quantities
{
    public class Length:Quantity{
        public Length(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Length");
            Unit = new meter();
        }
    }
}