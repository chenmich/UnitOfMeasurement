using System;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class second: Unit
    {
        public second(){
           
            string name = "second";
            string symbol = "s";
            int[] expression =  new int[]{0, 0, 1, 0, 0, 0, 0};
            IUnitSys sys = new TimeUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        internal second(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit)
            :base(sys, name, symbol, expressionByBaseUnit){}

    }
}
