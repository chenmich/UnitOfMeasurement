using System;
using System.Collections.Generic;
using UOM.Quantities;
using UOM.Units.UnitSys;

namespace UOM.Units
{
    public class Unit: IUnit
    {
        private static readonly Dictionary<string, int> _expression =  
            new Dictionary<string, int>();
        public   IUnitSys Sys{
            get;  internal set;
        }
        public   IUnit Multiply(IUnit right){
            throw new NotImplementedException("Unit.Mulityply");
        }
        public   IUnit Divide(IUnit right){
            throw new NotImplementedException("Unit.Divide");
        }

        public virtual string UnitName{
            get; 
            internal set;
        }
        public virtual string UnitSymbol{
            get; 
            internal set;
        }

        public virtual string ExpressionByBaseUnit{
            get{
                throw new NotImplementedException("Unit.ExpressionByBaseUnit.getter");
            }
        }
        
        internal Unit(){}
        internal Unit(IUnitSys sys, string name, 
            string symbol, int[] expressionByBaseUnit){
                _setContent(sys, name, symbol, expressionByBaseUnit);
        }
        protected virtual void _setContent(IUnitSys sys,  
            string name, string symbol, int[] expressByBaseUnit){
                Sys = sys;
                UnitName = name;
                UnitSymbol = symbol;
                
                _expression["m"] = expressByBaseUnit[0];
                _expression["kg"] = expressByBaseUnit[1];
                _expression["s"] = expressByBaseUnit[2];
                _expression["A"] = expressByBaseUnit[3];
                _expression["K"] = expressByBaseUnit[4];
                _expression["mole"] = expressByBaseUnit[5];
                _expression["cd"] = expressByBaseUnit[6];
            }
        
    }
}
