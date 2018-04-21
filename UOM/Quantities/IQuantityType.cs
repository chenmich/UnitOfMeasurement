using System;

namespace UOM.Quantities
{
    public interface IQuantityType
    {
        IQuantityType Multiply(IQuantityType quntityType);
        IQuantityType Divide(IQuantityType quntityType);
        IQuantityType Inverse();
    }
}
