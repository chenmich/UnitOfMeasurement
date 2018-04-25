using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml.Linq;
using System.Linq;

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
            foreach(XElement _typeContent in _typeInformations.Elements("QuantityType"))
            {
               (TypeId, IQuantityType) result = _getTypeFromXml(_typeContent);
               _typeSet.Add(result.Item1, result.Item2) ;
            }
            
            //register the expression of type
            foreach (XElement _typeContent in _typeInformations.Elements("quantityType")){
                XElement _expContent = _typeContent.Element("expression");
                if(_expContent.HasElements){
                    (TypeId, IQuantityType) result = _getTypeFromXml(_expContent);

                    //get type operand
                    XElement _leftOperand = _expContent.Element("left");
                    string _leftref = _leftOperand.Attribute("ref").Value;                    
                    XElement _rightOperand = _expContent.Element("right");
                    string _rightref = _rightOperand.Attribute("ref").Value;
                    _typeInformations.Elements("QuantityType").Where((x)=> x.Attribute(""))
                }
            }
        }

        private  (TypeId, IQuantityType) _getTypeFromXml(XElement _typeContent)
        {
            string _typeName = _typeContent.Element("name").Value;
            Guid _id = Guid.Parse(_typeContent.Element("id").Value);
            TypeId _Id = new TypeId(_id, _typeName);            
            return (_Id, new QuantityType(_Id));
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
