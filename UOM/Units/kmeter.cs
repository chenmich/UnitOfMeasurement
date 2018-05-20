using System;
using UOM.Units.Converter;
namespace UOM.Units
{
    public class kmeter:meter
    {
        public kmeter():base(){
            Converter = new ScaleConverter(1000f);
        }
    }
}
