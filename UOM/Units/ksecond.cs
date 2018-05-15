using System;

namespace UOM.Units
{
    public class ksecond:second
    {
        public override float fromPrimary(float value){
            return value / 1000;
        }

        public override float toPrimary(float value){
            return 1000 * value;
        }
    }
}
