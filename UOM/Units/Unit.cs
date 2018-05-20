using System;
using UOM.Units.UnitSys;
using UOM.Units.Converter;

namespace UOM.Units
{
    public class Unit: IUnit
    {
        public   IUnitSys Sys{
            get;  internal set;
        }
        public   IUnit Multiply(IUnit right){
            throw new NotImplementedException("Unit.Mulityply");
        }
        public   IUnit Divide(IUnit right){
            throw new NotImplementedException("Unit.Divide");
        }
        public IConverter Converter{
            get; internal set;
        }
        
        internal Unit(){}
        public Unit(IUnitSys sys):
            this(sys,  new ScaleConverter()){
        }
        public Unit(IUnitSys sys, IConverter converter){
            Sys = sys;
            Converter = converter;
        }
    }
}
