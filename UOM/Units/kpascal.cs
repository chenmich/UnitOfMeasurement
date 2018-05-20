using System;
using UOM.Units.Converter;
namespace UOM.Units
{
    public class kpascal:pascal
    {
        public kpascal():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
