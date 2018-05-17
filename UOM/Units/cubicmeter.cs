using System;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class cubicmeter:Unit
    {
        public cubicmeter(){
            string name = "cubicmeter";
            string symbol = "m^3";
            int[] expression = new int[]{3, 0, 0, 0, 0, 0, 0};
            IUnitSys sys = new VolumnUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        public cubicmeter(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}
    }
}
