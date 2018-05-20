using System;
using UOM.Quantities;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public   interface IUnit
    {        
        IUnitSys Sys{
            get;
        }

        IUnit Multiply(IUnit right);
        IUnit Divide(IUnit right);
        IConverter Converter{
            get;
        }
       

    }
}
