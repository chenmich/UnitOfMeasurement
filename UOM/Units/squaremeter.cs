using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class squaremeter:Unit
    {
        public squaremeter(){
            Sys = new AreaUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
