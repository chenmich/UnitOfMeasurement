using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class ksquaremeter:squaremeter
    {
        public ksquaremeter():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
