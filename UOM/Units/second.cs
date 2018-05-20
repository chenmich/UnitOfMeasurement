using System;
using UOM.Quantities;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class second: Unit
    {
        public second(){
            Sys = new TimeUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
