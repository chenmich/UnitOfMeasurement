using System;

namespace UOM.Quantities
{
    public class Mass:Quantity
    {
        public Mass(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Mass");
        }
    }
}
