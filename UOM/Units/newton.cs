using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class newton:Unit
    {
        public newton(){
            
            Sys = new ForceUnitSys();
            Converter = new ScaleConverter();
        }

    }
}