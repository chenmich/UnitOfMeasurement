using System;
using UOM.Units;

namespace UOM.Quantities
{
    public class Acceleration:Quantity
    {
        public Acceleration():base(QuantityTypeService.getService().getType("Acceleration"), 
                                    new meterpersecondsquare(), 0){
            
        }
        public Acceleration(IUnit unit, float value):base(QuantityTypeService.getService().getType("Acceleration"), 
                                                            unit, value){

        }
        public Acceleration(float value):base(QuantityTypeService.getService().getType("Acceleration"), 
                                                new meterpersecondsquare(), value){
        }
    }
}
