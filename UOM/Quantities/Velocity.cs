using System;
using UOM.Units;

namespace UOM.Quantities
{
    public class Velocity:Quantity
    {
        public Velocity(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type =  service.getType("Velocity");
            Unit = new meterpersecond();
        }
    }
}
