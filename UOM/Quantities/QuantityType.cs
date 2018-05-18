using System;
using System.Reflection;
using UOM.UOMException;
using UOM.Units.UnitSys;
namespace UOM.Quantities
{
    public class QuantityType:IQuantityType, IEquatable<QuantityType>
    {
        
        public TypeId Id{
            get; private set;
        }
        public IUnitSys Sys{
            get; internal set;
        }
        internal QuantityType(TypeId id){
            Id = id;
        }
        public IQuantityType Multiply(IQuantityType quntityType){
            TypeExpression exp = new TypeExpression(this,quntityType, TypeOperator.Multiply);
            QuantityTypeService service = QuantityTypeService.getService();
            return service.getType(exp);
        }
        public IQuantityType Divide(IQuantityType quntityType){
            TypeExpression exp = new TypeExpression(this, quntityType, TypeOperator.Divide);
            QuantityTypeService service = QuantityTypeService.getService();
            return service.getType(exp);
        }
        public IQuantity getQuantity(){
            string _typeName = Id.Name;
            Assembly _thisAssem = typeof(QuantityTypeService).Assembly;
            Type _type = _thisAssem.GetType("UOM.Quantities." + _typeName);
            if(_type == null) throw  new  QuantityTypeNotExistedException();
            string typeFullName = _type.FullName;       
            // object[] arg = new object[] {this};

            IQuantity quantityInstance = _thisAssem
                .CreateInstance(typeFullName) as IQuantity;
            return quantityInstance;
        }

        #region for equality check

        public override bool Equals(object obj){
            if(object.ReferenceEquals(this, obj)) return true;
            if(object.ReferenceEquals(obj, null)) return false;
            QuantityType _type = obj as QuantityType;
            if(object.Equals(_type, null)) return false;
            else return this.Equals(_type);
        }
        public bool Equals(QuantityType type){
            return this.Id.Equals(type.Id);
        }

        public override int GetHashCode() => this.Id.GetHashCode();

        public override string ToString(){
            return string.Format("TypeId: {0},   TypeName: {1}", this.Id.Id, this.Id.Name);
        }
        public static  bool operator==(QuantityType left, QuantityType right){
            return left.Equals(right);
        }
        public static bool operator!=(QuantityType left, QuantityType right){
            return !left.Equals(right);
        }
        #endregion
    }
}