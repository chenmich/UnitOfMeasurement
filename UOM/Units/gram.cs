using System;

namespace UOM.Units
{
    public class gram:kilogram
    {
        public override float fromPrimary(float value){
            return 1000*value;
        }
        public override float toPrimary(float value){
            return value / 1000;
        }
    }
}
