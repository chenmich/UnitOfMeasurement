using System;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class candela:Unit
    {
        public candela(){
            string name = "candela";
            string symbol = "cd";
            int[] expression = new int[]{0, 0, 0, 0, 0, 0, 1};
            IUnitSys sys = new LuminousIntensityUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        public candela(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}
    }
}
