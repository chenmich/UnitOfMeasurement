using System;
using UOM.Units;

namespace UOM.Quantities
{
    public interface IQuantity
    {
        IUnit Unit{
            get;
        }
        IQuantity toUnit(IUnit unit);
        IQuantityType Type{
            get;
        }
        IQuantity Multiply(IQuantity quantity);
        IQuantity Divide(IQuantity quantity);
        IQuantity Add(IQuantity quantity);
        IQuantity Substract(IQuantity quantity);
        float Value{
            get;
        }
    }
}