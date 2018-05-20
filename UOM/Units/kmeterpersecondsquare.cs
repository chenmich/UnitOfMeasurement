using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class kmeterpersecondsquare:meterpersecondsquare
    {
        public kmeterpersecondsquare():base(){
            Converter = new ScaleConverter(1000f);
        }
    }
}
