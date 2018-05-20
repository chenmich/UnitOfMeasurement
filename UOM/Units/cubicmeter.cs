using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class cubicmeter:Unit
    {
        public cubicmeter(){
            Sys = new VolumnUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
