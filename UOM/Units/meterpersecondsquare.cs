using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class meterpersecondsquare:Unit
    {
        public meterpersecondsquare(){
            
            Sys = new AccelerationUnitSys();
            Converter = new ScaleConverter();
        }
    }
}
