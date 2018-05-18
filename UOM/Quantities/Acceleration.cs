using System;
using UOM.Units;
using UOM.Units.UnitSys;

namespace UOM.Quantities
{
    public class Acceleration:Quantity
    {
        public Acceleration(){
            QuantityTypeService service = QuantityTypeService.getService();
            Type = service.getType("Acceleration");
            IUnitSys sys = new AccelerationUnitSys();
            Unit = sys.Primary;
        }
        public Acceleration(float value):this(){
            Value = value;
        }
        public Acceleration(IUnit unit, float value):this(value){
            Unit = unit;
        }
    }
}
