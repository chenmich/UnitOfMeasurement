using System;

namespace UOM.Quantities
{
    public interface IQuantity
    {
        IQuantityType Type{
            get;
        }
        IQuantity Multiply(IQuantity quntity);
        IQuantity Divide(IQuantity quntity);
    }
}
