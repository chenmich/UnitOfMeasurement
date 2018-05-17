using System;
using UOM.Units.UnitSys;


namespace UOM.Units
{
    public class one:Unit
    {
        public one(){
            string name = "one";
            string symbol = "one";
            int[] expression = new int[]{0, 0, 0, 0, 0, 0, 0};
            IUnitSys sys = new IdentityUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        public one(IUnitSys sys, string name, string symbol, int[] expression):
            base(sys, name, symbol, expression){}
    }
}
