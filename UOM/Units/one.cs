using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class one:Unit
    {
        public one(){
            Sys = new IdentityUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
