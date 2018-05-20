using System;
using UOM.Quantities;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class kelvin:Unit
    {
        public kelvin(){
            Sys = new ThermodynamicTemperatureUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
