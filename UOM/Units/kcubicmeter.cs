using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class kcubicmeter:cubicmeter
    {
        public kcubicmeter():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
