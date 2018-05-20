using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class pascal:Unit
    {
        public pascal(){
            Sys = new StressUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
