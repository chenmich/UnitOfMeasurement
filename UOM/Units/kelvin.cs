using System;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class kelvin:Unit
    {
        public kelvin(){
            string name = "kelvin";
            string symbol = "K";
            int[] expression = new int[]{0, 0, 0, 0, 1, 0, 0};
            IUnitSys sys = new ThermodynamicTemperatureUnitSys();
            _setContent(sys, name, symbol, expression);
        }

        public kelvin(IUnitSys sys, string name, string symbol, int[] expressionByBaseUnit):
            base(sys, name, symbol, expressionByBaseUnit){}
    }
}
