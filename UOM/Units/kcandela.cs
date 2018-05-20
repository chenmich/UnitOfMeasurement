using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class kcandela:candela
    {
        public kcandela():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
