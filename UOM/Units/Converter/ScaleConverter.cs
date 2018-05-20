using System;

namespace UOM.Units.Converter
{
    public class ScaleConverter:IConverter
    {
        private readonly float _factor = 1;
        public ScaleConverter(){}

        //factor for from this unit  to primary unit
        public ScaleConverter(float factor){
            _factor = factor;
        }

        public float toPrimary(float value){
            return _factor * value;
        }
        public float fromPrimary(float value){
            return  value / _factor;
        }
    }
}
