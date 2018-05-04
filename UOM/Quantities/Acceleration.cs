using System;

namespace UOM.Quantities
{
    public class Acceleration:Quantity
    {
        public Acceleration(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Acceleration");
        }
    }
}
