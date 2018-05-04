using System;

namespace UOM.Quantities
{
    public class Force:Quantity
    {
        public Force(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Force");
        }
    }
}
