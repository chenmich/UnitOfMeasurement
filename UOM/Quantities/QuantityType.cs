using System;

namespace UOM.Quantities
{
    public class QuantityType:IQuantityType, IEquatable<QuantityType>
    {
        protected Guid Id{
            get; set;
        }
        protected string Name{
            get; set;
        }
        internal QuantityType(){

        }

        internal QuantityType(Guid id, string name){
            Id = id;
            Name = name;
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
            return this.Id.Equals(type.Id) && this.Name.Equals(type.Name);
        }

        public override int GetHashCode() => this.Id.GetHashCode() ^ this.Name.GetHashCode();

        public override string ToString(){
            return string.Format("TypeId{0}, TypeName{1}", this.Id, this.Name);
        }
        public static  bool operator==(QuantityType left, QuantityType right){
            return left.Equals(right);
        }
        public static bool operator!=(QuantityType left, QuantityType right){
            return !left.Equals(right);
        }
        #endregion
    }
    public sealed class IdentityType: QuantityType{
        internal IdentityType(){

        }
    }
}