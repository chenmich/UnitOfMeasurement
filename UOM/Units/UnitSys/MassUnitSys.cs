using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public class MassUnitSys:UnitSys
    {
        public override IUnit k{
            get{
                return new kilogram();
            }
        }

        public override IUnit Primary{
            get{
                return new kilogram();
            }
        }

        public override IUnit Common{
            get{
                return new kilogram();
            }
        }

        public MassUnitSys(){
            
        }
    }
}
