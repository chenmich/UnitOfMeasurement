using System;
using UOM.Units;

namespace UOM.Units.UnitSys
{
    public class AccelerationUnitSys:UnitSys
    {
        public override IUnit k{
            get{
                return new kmeterpersecondsquare();
            }
        }

        public override IUnit Primary{
            get{
                return new meterpersecondsquare();
            }
        }

        public override IUnit Common{
            get{
                return new meterpersecondsquare();
            }
        }

        public AccelerationUnitSys(){
            
        }
    }
}