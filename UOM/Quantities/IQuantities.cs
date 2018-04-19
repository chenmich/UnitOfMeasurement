using System;

namespace UOM.Quantities
{
    public interface IQuantity<T>
    {
        IQuantity<T> Multiply(IQuantity<T> quntity);
        IQuantity<T> Divide(IQuantity<T> quntity);
        IQuantity<T> Inverse();
    }
}
