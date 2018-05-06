using System;
using UOM.Quantities;

namespace UOM.Units
{
    public class kilogram:Unit
    {
        public kilogram(){
            
            IUnit primary = this;
            IUnit common = this;
            string name = "kilogram";
            string symbol = "kg";
            int[] expression = new int[]{0, 1, 0, 0, 0, 0, 0};
            _setContent("Mass", primary, common, name, symbol, expression);
        }
        public kilogram(string qtype, IUnit primary, IUnit common, string name, string symbol, int[] pressionByBaseUnit)
            :base(qtype, primary, common, name, symbol, pressionByBaseUnit){}
    }
}
