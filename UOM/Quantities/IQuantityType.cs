using System;

namespace UOM.Quantities
{
    public interface IQuantityType
    {
        TypeId Id{
            get;
        }
        IQuantity ProtoType{
            get;
        }
        IQuantityType Multiply(IQuantityType quntityType);
        IQuantityType Divide(IQuantityType quntityType);
        IQuantityType Inverse();
    }
}
