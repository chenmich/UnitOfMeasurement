using System;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class meterpersecondsquare:Unit
    {
        public meterpersecondsquare(){
            
            string name = "meterpersecondsquare";
            string symbol = "m/s^2";
            int[] expression = new int[]{1, 0, -2, 0, 0, 0, 0};
            IUnitSys sys = new AccelerationUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        internal meterpersecondsquare(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}
    }
}
