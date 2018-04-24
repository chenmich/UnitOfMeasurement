using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("UOMTest")]
namespace UOM.Quantities
{
    internal  class QuantityTypeService{
        private static readonly Dictionary<TypeExpression, IQuantityType> _expressionSet
            = new Dictionary<TypeExpression, IQuantityType>();
        private static readonly Dictionary<TypeId, IQuantityType> _typeSet 
            = new Dictionary<TypeId, IQuantityType>();
        
        private static  QuantityTypeService _instance 
            = new QuantityTypeService();
        
        private QuantityTypeService(){
            XElement _typeInformations = getTypeInformations();
            //register the type
            foreach(XElement _typeContent in _typeInformations.Elements("QuantityType")){
                string _typeName = _typeContent.Element("name").Value;
                Guid _id = Guid.Parse(_typeContent.Element("id").Value);
                TypeId _Id = new TypeId(_id, _typeName);
                IQuantityType _type = new QuantityType(_Id);
                _typeSet.Add(_Id, _type); 
            }
            //register the expression of type
            foreach(XElement _typeContent in _typeInformations.Elements("quantityType")){
                
            }           
            
        }

        private XElement getTypeInformations(){
            string  current = Directory.GetCurrentDirectory();
            DirectoryInfo curinfo = new DirectoryInfo(current);
            DirectoryInfo parent = curinfo.Parent;
            parent = parent.Parent;
            parent = parent.Parent;
            parent = parent.Parent;
            string typeInfo = parent.FullName + "/CreateQuantityClass/QuantityType.xml";
            return XElement.Load(typeInfo);
            
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static  QuantityTypeService getService(){
            return _instance;
        }
        
        private  IQuantityType LogType(TypeExpression expression){
            throw new NotImplementedException("QuantityTypeService.LogType");
        }
        internal IQuantityType getType(string name, Guid id){
            TypeId _Id = new TypeId(id, name);
            return _typeSet[_Id];
        }
        internal IQuantityType getType(TypeExpression expression){
            throw new NotImplementedException("QuantityTypeService.GetType");
        }
        
        public IQuantityType GetBaseType(){
            throw new NotImplementedException("QuantityTypeService.GetBaseType");
        }

    }
}
