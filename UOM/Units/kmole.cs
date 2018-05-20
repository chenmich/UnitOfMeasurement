using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class kmole:mole
    {
        public kmole():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
