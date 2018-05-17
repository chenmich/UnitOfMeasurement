using System;
using UOM.Units.UnitSys;

namespace UOM.Quantities
{
    public interface IQuantityType
    {
        TypeId Id{
            get;
        }
        IUnitSys Sys{
            get;
        }
        IQuantityType Multiply(IQuantityType quntityType);
        IQuantityType Divide(IQuantityType quntityType);
        IQuantityType Inverse();
    }
}
