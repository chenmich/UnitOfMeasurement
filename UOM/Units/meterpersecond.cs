using System;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class meterpersecond:Unit
    {
        public meterpersecond(){
            
            string name = "meterpersecond";
            string symbol = "m/s";
            int[] expression = new int[]{1, 0, -1, 0, 0, 0, 0};
            IUnitSys sys = new VelocityUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        internal meterpersecond(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}
    }
}
