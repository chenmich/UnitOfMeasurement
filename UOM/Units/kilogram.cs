using System;
using UOM.Quantities;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class kilogram:Unit
    {
        public kilogram(){
            Sys = new MassUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
