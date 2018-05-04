using System;
using UOM.Quantities;

namespace UOM.Units
{
    public class meterpersecond:Unit
    {
        public meterpersecond(){
            IUnit primary = this;
            IUnit common = this;
            string name = "meterpersecond";
            string symbol = "m/s";
            int[] expression = new int[]{1, 0, -1, 0, 0, 0, 0};
            _setContent("Velocity", primary, common, name, symbol, expression);
        }

        internal meterpersecond(string qtype, IUnit primary, IUnit common, string name, string symbol, int[] expressionByBaseUnit):
            base(qtype, primary, common, name, symbol, expressionByBaseUnit){}
    }
}
