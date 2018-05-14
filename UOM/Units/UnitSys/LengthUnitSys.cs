using System;

namespace UOM.Units.UnitSys
{
    public class LengthUnitSys:UnitSys
    {
        public override IUnit k{
            get{
                return new kmeter();
            }
        }
        public override IUnit Primary{
            get{
                return new meter();
            }
        }
        public override IUnit Common{
            get{
                return new kmeter();
            }
        }
        public LengthUnitSys(){
            
        }
    }
}
