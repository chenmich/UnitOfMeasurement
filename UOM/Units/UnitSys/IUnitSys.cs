using System;
using UOM.Quantities;

namespace UOM.Units.UnitSys
{
    public interface IUnitSys
    {
        IQuantityType  QType{
            get;
        }
        IUnit Primary{
            get;
        } 
        IUnit Common{
            get;
        }

        IUnit k{
            get;
        }
    }
}
