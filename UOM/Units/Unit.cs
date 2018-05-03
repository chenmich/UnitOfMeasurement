using System;
using UOM.Quantities;

namespace UOM.Units
{
    internal   class Unit: IUnit
    {
        public   IQuantityType QType{
            get;  internal set;
        }
        public   IUnit Multiply(IUnit right){
            throw new NotImplementedException("Unit.Mulityply");
        }
        public   IUnit Divide(IUnit right){
            throw new NotImplementedException("Unit.Divide");
        }

        public string UnitName{
            get; 
            internal set;
        }
        public string UnitSymbol{
            get; 
            internal set;
        }

        public string ExpressionByBaseUnit{
            get{
                throw new NotImplementedException("Unit.ExpressionByBaseUnit.getter");
            }
        }
        internal Unit(){}
    }
}
