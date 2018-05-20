using System;
using UOM.Units.Converter;
namespace UOM.Units
{
    public class kmeterpersecond:meterpersecond
    {
        public kmeterpersecond():base(){
            Converter = new ScaleConverter(1.0e+3);
        }
    }
}
