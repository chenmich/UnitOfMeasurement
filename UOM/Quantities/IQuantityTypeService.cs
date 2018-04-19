using System;

namespace UOM.Quantities
{
    internal interface IQuantityTypeService
    {
        IQuantityType LogType(TypeExpression expression);
        IQuantityType GetType(TypeExpression expression);
        IQuantityType GetBaseType(); 
    }
}
