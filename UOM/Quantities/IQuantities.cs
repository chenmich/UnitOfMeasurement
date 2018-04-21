using System;

namespace UOM.Quantities
{
    public interface IQuantity
    {
        IQuantity Multiply(IQuantity quntity);
        IQuantity Divide(IQuantity quntity);
        IQuantity Inverse();
    }
}
