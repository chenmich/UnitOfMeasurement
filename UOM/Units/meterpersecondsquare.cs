using System;

namespace UOM.Units
{
    public class meterpersecondsquare:Unit
    {
        public meterpersecondsquare(){
            IUnit primary = this;
            IUnit common = this;
            string name = "meterpersecondsquare";
            string symbol = "m/s^2";
            int[] expression = new int[]{1, 0, -2, 0, 0, 0, 0};
            _setContent("Acceleration", primary, common, name, symbol, expression);
        }

        internal meterpersecondsquare(string qtype, IUnit primary, IUnit common, string name, string symbol, int[] expressionByBaseUnit):
            base(qtype, primary, common, name, symbol, expressionByBaseUnit){}
    }
}
