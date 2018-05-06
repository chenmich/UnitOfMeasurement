using System;
using UOM.Units;
using UOM.Quantities;

namespace UOM.Units
{
    public class meter: Unit
    {
        public meter()
        {
            
            string name = "meter";
            string symbol = "m";
            IUnit primary = this;
            IUnit common = this;
            int[] expression = new int[]{1, 0, 0, 0, 0, 0, 0};
            _setContent("Length", primary, common, name, symbol, expression);            
        }
        internal meter(string qtype, IUnit primary, IUnit common, string name, string symbol, int[] expression) 
            :base(qtype, primary, common, name, symbol, expression){}
    }
    
}
