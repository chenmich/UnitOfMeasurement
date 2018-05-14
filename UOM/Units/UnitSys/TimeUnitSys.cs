using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class TimeUnitSys:UnitSys
    {
        public override IUnit k{
            get{
                return new ksecond();
            }
        }

        public override IUnit Primary{
            get{
                return new second();
            }
        }

        public override IUnit Common{
            get{
                return new second();
            }
        }

        public TimeUnitSys(){
            
        }
    }
}
