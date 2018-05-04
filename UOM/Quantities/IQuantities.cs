using System;
using UOM.Units;

namespace UOM.Quantities
{
    public interface IQuantity
    {
        IUnit Unit{
            get;
        }
        IQuantityType Type{
            get;
        }
        IQuantity Multiply(IQuantity quntity);
        IQuantity Divide(IQuantity quntity);
    }
}
