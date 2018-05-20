using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class mole:Unit
    {
        public mole(){
           Sys = new AmountOfSubstanceUnitSys();
           Converter = new ScaleConverter();
        }
    }
}
