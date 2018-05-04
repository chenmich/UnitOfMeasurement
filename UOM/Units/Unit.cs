using System;
using System.Collections.Generic;
using UOM.Quantities;

namespace UOM.Units
{
    public class Unit: IUnit
    {
        private static readonly Dictionary<string, int> _expression =  
            new Dictionary<string, int>();
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
        public IUnit PrimaryUnit{
            get; internal set;
        }
        public IUnit CommonUnit{
            get; internal set;
        }
        internal Unit(){}
        internal Unit(string qtype, IUnit primary, IUnit common, string name, 
            string symbol, int[] expressionByBaseUnit){
                _setContent(qtype, primary, common, name, symbol, expressionByBaseUnit);
        }
        protected virtual void _setContent(string qtype, IUnit primary, IUnit common, 
            string name, string symbol, int[] expressByBaseUnit){
                QuantityTypeService service = QuantityTypeService.getService();
                IQuantityType _qtype = service.getType(qtype);
                QType = _qtype;
                UnitName = name;
                UnitSymbol = symbol;
                PrimaryUnit = primary;
                CommonUnit = common;
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
