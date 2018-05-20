using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class ksecond:second
    {
        public ksecond():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
