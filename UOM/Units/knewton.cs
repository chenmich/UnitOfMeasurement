using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class knewton:newton
    {
        public knewton():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
