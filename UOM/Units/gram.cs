using System;
using UOM.Units.Converter;
namespace UOM.Units
{
    public class gram:kilogram
    {
        public gram():base(){
            Converter = new ScaleConverter(0.001f);
        }
    }
}
