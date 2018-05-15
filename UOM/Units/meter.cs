using System;
using UOM.Units;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class meter: Unit
    {
        public meter()
        {           
            string name = "meter";
            string symbol = "m";
            int[] expression = new int[]{1, 0, 0, 0, 0, 0, 0};
            IUnitSys sys = new LengthUnitSys();
            _setContent(sys, name, symbol, expression);            
        }
        internal meter(IUnitSys sys,  string name, string symbol, int[] expression) 
            :base(sys, name, symbol, expression){}
        
        
    }
    
}
