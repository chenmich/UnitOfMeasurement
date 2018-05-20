using System;
using UOM.Quantities;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class meterpersecond:Unit
    {
        public meterpersecond(){
            Sys = new VelocityUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
