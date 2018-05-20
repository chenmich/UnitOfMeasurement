using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class ampere:Unit
    {
        public ampere(){
            Sys = new ElectricCurrentUnitSys();
            Converter  = new ScaleConverter();
        }
    }
}
