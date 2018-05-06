using System;
using UOM.Units;

namespace UOM.Quantities
{
    public class Mass:Quantity
    {
        public Mass(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Mass");
            Unit = new kilogram();
        }
    }
}
