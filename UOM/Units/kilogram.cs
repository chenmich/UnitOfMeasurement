using System;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class kilogram:Unit
    {
        public kilogram(){
            string name = "kilogram";
            string symbol = "kg";
            int[] expression = new int[]{0, 1, 0, 0, 0, 0, 0};
            IUnitSys sys = new MassUnitSys();
            _setContent(sys, name, symbol, expression);
        }
        public kilogram(IUnitSys sys,  string name, string symbol, int[] pressionByBaseUnit)
            :base(sys, name, symbol, pressionByBaseUnit){}
    }
}
