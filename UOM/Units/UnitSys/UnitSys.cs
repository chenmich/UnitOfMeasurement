using System;
using UOM.Quantities;


namespace UOM.Units.UnitSys
{
    public  abstract class UnitSys:IUnitSys
    {
        public virtual IQuantityType QType{
            get; internal set;
        }
        public virtual IUnit Primary{
            get; internal set;
        }
        public virtual IUnit Common{
            get; internal set;
        }
        public virtual IUnit k{
            get;
        }
    }
}
