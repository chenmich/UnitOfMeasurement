using System;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class mampere:ampere
    {
        public mampere():base(){
            Converter = new ScaleConverter(1.0e-3);
        }
    }
}
