using System;
using UOM.Units;

namespace UOM.Quantities
{
    public class Time:Quantity
    {
        public Time(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Time");
            Unit = new second();
        }

    }
}
