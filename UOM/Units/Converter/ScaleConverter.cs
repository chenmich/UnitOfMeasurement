using System;

namespace UOM.Units.Converter
{
    public class ScaleConverter:IConverter
    {
        private readonly double _factor = 1;
        public ScaleConverter(){}

        //factor for from this unit  to primary unit
        public ScaleConverter(double factor){
            _factor = factor;
        }

        public double toPrimary(double value){
            return _factor * value;
        }
        public double fromPrimary(double value){
            return  value / _factor;
        }
    }
}
