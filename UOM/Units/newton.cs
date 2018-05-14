using System;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class newton:Unit
    {
        public newton(){
            
            string name = "newton";
            string symbol = "N";
            int[] epxpression = new int[]{1, 1, -2, 0, 0, 0, 0};
            IUnitSys sys = new ForceUnitSys();
            _setContent(sys, name, symbol, epxpression);
        }

        internal newton(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}

    }
}