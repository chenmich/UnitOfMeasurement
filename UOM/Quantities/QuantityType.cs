using System;

namespace UOM.Quantities
{
    public class QuantityType:IQuantityType, IEquatable<QuantityType>
    {
        public TypeId Id{
            get; private set;
        }
        internal QuantityType(string name):this(new TypeId(Guid.NewGuid(), name)){
        }

        internal QuantityType(TypeId id){
            Id = id;
        }
        public IQuantityType Multiply(IQuantityType quntityType){
            throw new NotImplementedException("quntityType.Multiply");
        }
        public IQuantityType Divide(IQuantityType quntityType){
            throw new NotImplementedException("QuntityType.Divide");
        }
        public IQuantityType Inverse(){
            throw new NotImplementedException("QuntityType.Inserve");
        }

        #region for equality check

        public override bool Equals(object obj){
            if(object.ReferenceEquals(this, obj)) return true;
            if(object.ReferenceEquals(obj, null)) return false;
            QuantityType _type = obj as QuantityType;
            if(_type == null) return false;
            else return this.Equals(_type);
        }
        public bool Equals(QuantityType type){
            return this.Id.Equals(type.Id);
        }

        public override int GetHashCode() => this.Id.GetHashCode();

        public override string ToString(){
            return string.Format("TypeId{0}, TypeName{1}", this.Id.Id, this.Id.Name);
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