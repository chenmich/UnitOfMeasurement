using System;

namespace UOM.Quantities
{
    internal  class QuantityTypeService: IQuantityTypeService{
        internal QuantityTypeService(){}
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
