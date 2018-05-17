using System;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class ampere:Unit
    {
        public ampere(){
            string name = "ampere";
            string symbol = "A";
            int[] expression = new int[]{0, 0, 0, 0, 0, 0, 0};
            IUnitSys sys = new ElectricCurrentUnitSys();
            _setContent(sys, name, symbol, expression);
        }
        public ampere(IUnitSys sys,  string name, string symbol, int[] expressionByBaseUnit)
            :base(sys, name, symbol, expressionByBaseUnit){}
    }
}
