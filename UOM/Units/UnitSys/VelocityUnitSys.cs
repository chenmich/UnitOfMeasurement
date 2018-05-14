using System;
using UOM.Units;


namespace UOM.Units.UnitSys
{
    public class VelocityUnitSys:UnitSys
    {
        public override IUnit k{
            get{
                return new kmeterpersecond();
            }
        }

        public override IUnit Primary{
            get{
                return new meterpersecond();
            }
        }

        public override IUnit Common{
            get{
                return new kmeterpersecond();
            }
        }

        public VelocityUnitSys(){
            
        }

    }
}
