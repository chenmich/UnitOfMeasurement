using System;

namespace UOM.Quantities{
    public  class TypeId{
        public Guid Id{
            get; private set;
        }
        public string Name{
            get; private set;
        }
        public TypeId(Guid id, string name){
            Id = id;
            Name = name;
        }
        public override string ToString(){
            return string.Format("id: {0}\nname: {1}", Id.ToString(), Name);
        }
        public TypeId(string name):this(Guid.NewGuid(), name){}
        #region for equality
        public override bool Equals(object obj)
        {            
            if(obj == null) return false;
            if(object.ReferenceEquals(this, obj)) return true;
            
            TypeId id = obj as TypeId;
            if(Object.Equals(id, null)) 
                return false;
            else
                return Equals (id);
        }
        public bool Equals(TypeId typeId){
            return this.Id.Equals(typeId.Id)  && this.Name.Equals(typeId.Name);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode();
        }

        public static bool operator==(TypeId left, TypeId right){
            return left.Equals(right);
        }
        public static bool operator!=(TypeId left, TypeId right){
            return !left.Equals(right);
        }
        #endregion

    }
}