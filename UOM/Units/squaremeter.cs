using System;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class squaremeter:Unit
    {
        public squaremeter(){
            string name = "squaremeter";
            string symbol = "m^2";
            int[] expression = new int[]{2, 0, 0, 0, 0, 0, 0};
            IUnitSys sys = new AreaUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        public squaremeter(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}
    }
}
