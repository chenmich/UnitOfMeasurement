using System;

namespace UOM.Quantities
{
    internal interface IQuantityTypeService
    {
        bool LogType();
        IQuantityType GetType();
    }

    internal class TypeExpression{
        internal IQuantityType left{
            get; private set;
        }
        internal IQuantityType right{
            get; private set;
        }
        
        internal TypeOperator Operator{
            get; private set;
        }
    }

    internal enum TypeOperator{ multiply=0, divide, inserve}
}
