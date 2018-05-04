using System;
using UOM.Quantities;

namespace UOM.Units
{
    public   interface IUnit
    {
        
        IQuantityType QType{
            get;
        }

        string UnitName{
            get;
        }
        string UnitSymbol{
            get;
        }
        string ExpressionByBaseUnit{
            get;
        }

        IUnit Multiply(IUnit right);
        IUnit Divide(IUnit right);

    }
}
