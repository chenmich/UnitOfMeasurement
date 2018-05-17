using System;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class pascal:Unit
    {
        public pascal(){
            string name = "pascal";
            string symbol = "Pa";
            int[] expression = new int[]{-1, 1, -2, 0, 0, 0, 0};
            IUnitSys sys = new StressUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        public pascal(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}
    }
}
