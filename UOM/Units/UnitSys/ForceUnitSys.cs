using System;
using UOM.Units;

namespace UOM.Units.UnitSys
{
    public class ForceUnitSys:UnitSys
    {
        public override IUnit k{
            get{
                return new knewton();
            }
        }

        public override IUnit Primary{
            get{
                return new newton();
            }
        }

        public override IUnit Common{
            get{
                return new knewton();
            }
        }

        public ForceUnitSys(){
            
        }

    }
}
