using System;
using UOM.Quantities;

namespace UOM.Units
{
    public class newton:Unit
    {
        public newton(){
            IUnit primary = this;
            IUnit common = this;
            string name = "newton";
            string symbol = "N";
            int[] epxpression = new int[]{1, 1, -2, 0, 0, 0, 0};
            _setContent("Force", primary, common, name, symbol, epxpression);
        }

        internal newton(string qtype, IUnit primary, IUnit common, string name, string symbol, int[] expressionByBaseUnit):
            base(qtype, primary, common, name, symbol, expressionByBaseUnit){}

    }
}