using System;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class mole:Unit
    {
        public mole(){
            string name = "mole";
            string symbol = "mol";
            int[] expression = new int[]{0, 0, 0, 0, 0, 1, 0};
            IUnitSys sys = new AmountOfSubstanceUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        public mole(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}


    }
}
