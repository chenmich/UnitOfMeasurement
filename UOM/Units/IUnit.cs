using System;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public   interface IUnit
    {
        
        IUnitSys Sys{
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
