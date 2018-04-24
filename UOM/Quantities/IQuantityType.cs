using System;

namespace UOM.Quantities
{
    public interface IQuantityType
    {
        TypeId Id{
            get;
        }
        IQuantityType Multiply(IQuantityType quntityType);
        IQuantityType Divide(IQuantityType quntityType);
        IQuantityType Inverse();
    }
}
