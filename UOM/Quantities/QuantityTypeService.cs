using System;
using System.Collections.Generic;

namespace UOM.Quantities
{
    internal  class QuantityTypeService: IQuantityTypeService{
        private static readonly Dictionary<TypeExpression, IQuantityType> _typeSet
            = new Dictionary<TypeExpression, IQuantityType>();
        internal QuantityTypeService(){
            _registerForExisted();
        }

        void _registerForExisted(){
            _registerBaseType();
            _registerDerivedType();
        }

        void _registerBaseType(){
            string[] baseTypeName = {"Length","Mass", "Time", "Electric Current",
                                    "Thermodynamic Temperature", "Tmount of Substance",
                                    "Luminous Intensity", "Identity"};
            foreach(string name in baseTypeName){
                TypeExpression _exp = new TypeExpression();
                _exp.Right = new IdentityType();
                _exp.Left = new QuantityType();
                _exp.Operator = TypeOperator.multiply;
                _typeSet.Add(_exp, _exp.Left);                     
            }
        }
        public  IQuantityType LogType(TypeExpression expression){
            throw new NotImplementedException("QuantityTypeService.LogType");
        }
        public IQuantityType GetType(TypeExpression expression){
            throw new NotImplementedException("QuantityTypeService.GetType");
        }
        public IQuantityType GetBaseType(){
            throw new NotImplementedException("QuantityTypeService.GetBaseType");
        }
    }
}
