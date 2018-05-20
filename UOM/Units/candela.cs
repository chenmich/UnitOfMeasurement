using System;
using UOM.Quantities;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class candela:Unit
    {
        public candela(){
            Sys = new LuminousIntensityUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
