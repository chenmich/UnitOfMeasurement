using System;
using UOM.Units;

namespace UOM.Quantities
{
    public class Force:Quantity
    {
        public Force(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Force");
            Unit = new Newton();
        }
    }
}
