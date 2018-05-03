using System;

namespace UOM.Quantities
{
    public class Identity: Quantity
    {
        public Identity(){
            QuantityTypeService service = QuantityTypeService.getService();            
            IQuantityType type = service.getType("Identity");
            Type = type;
        }
    }
}
