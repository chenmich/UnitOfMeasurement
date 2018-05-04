using System;
using UOM.Quantities;

namespace UOM.Units
{
    public class s: Unit
    {
        public s(){
            IUnit primary = this;
            IUnit common = this;
            string name = "second";
            string symbol = "s";
            int[] expression =  new int[]{0, 0, 1, 0, 0, 0, 0};
            _setContent("Time", primary, common, name, symbol, expression);
        }

        internal s(string qtype, IUnit primary, IUnit common, string name, string symbol, int[] expressionByBaseUnit)
            :base(qtype, primary, common, name, symbol, expressionByBaseUnit){}

    }
}
