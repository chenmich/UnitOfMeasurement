using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class Mpascal:pascal
    {
        public Mpascal():base(){
            Converter = new ScaleConverter(1.0e+6);
        }
    }
}
