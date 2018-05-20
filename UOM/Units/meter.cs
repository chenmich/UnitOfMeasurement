using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class meter: Unit
    {
        public meter()
        {
            Sys = new LengthUnitSys();
            Converter = new ScaleConverter();
        }
    }
    
}
