using System;
using UOM.Units;
using UOM.Quantities;

namespace UOM.Units
{
    public class m: Unit
    {
        public m()
        {
            
            string name = "meter";
            string symbol = "m";
            IUnit primary = this;
            IUnit common = this;
            int[] expression = new int[]{1, 0, 0, 0, 0, 0, 0};
            _setContent("Length", primary, common, name, symbol, expression);            
        }
        internal m(string qtype, IUnit primary, IUnit common, string name, string symbol, int[] expression) 
            :base(qtype, primary, common, name, symbol, expression){}
    }
    
}
