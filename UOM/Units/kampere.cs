using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class kampere:ampere
    {
        public kampere():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
