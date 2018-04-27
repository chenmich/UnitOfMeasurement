using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using UOM.UOMException;
using System.Reflection;

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
            //register the type and quantity protype
            foreach(XElement _typeContent in _typeInformations.Elements("QuantityType"))
            {
               (TypeId, IQuantityType) result = _getTypeFromXml(_typeContent);
               _typeSet.Add(result.Item1, result.Item2) ;
            }
            
            //register the expression of type
            foreach (XElement _typeContent in _typeInformations.Elements("QuantityType")){
                XElement _expContent = _typeContent.Element("expression");
                if(_expContent.HasElements){
                    //get result type
                    TypeId  resultId = _getTypeId(_typeContent);

                    //get type operand                               .
                    string _leftref = _expContent.Element("left")
                                                .Attribute("ref").Value;                   
                    string _rightref = _expContent.Element("right")
                                                    .Attribute("ref").Value;
                    XElement _leftContent =                   
                            _typeInformations.Elements("QuantityType")
                                            .Where((x)=> x.Attribute("code").Value == _leftref)
                                            .First();
                    XElement _rightContent = 
                            _typeInformations.Elements("QuantityType")
                                            .Where((x)=>x.Attribute("code").Value == _rightref)
                                            .First();
                    TypeId leftId = _getTypeId(_leftContent);
                    TypeId rightId = _getTypeId(_rightContent);
                    
                    string _op = _expContent.Element("operator").Value;
                    TypeOperator op = TypeOperator.Divide;
                    if(_op == "Multiply") op = TypeOperator.Multiply;
                    TypeExpression typeExp = 
                                new TypeExpression(_typeSet[leftId], _typeSet[rightId], op);
                    LogType(typeExp, _typeSet[resultId]);
                }
            }
        }

        private  (TypeId, IQuantityType) _getTypeFromXml(XElement typeContent)
        {
            TypeId _Id = _getTypeId(typeContent);
            IQuantityType _quantityType = new QuantityType(_Id);
            return (_Id, _quantityType);
        }
        

        private  TypeId _getTypeId(XElement typeContent)
        {
            string _typeName = typeContent.Element("name").Value;
            Guid _id = Guid.Parse(typeContent.Element("id").Value);
            TypeId _Id = new TypeId(_id, _typeName);
            return _Id;
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
        
        private  void LogType(TypeExpression expression, IQuantityType result){
            
            TypeExpression _newExp;
            IQuantityType _newResult;
            List<(TypeExpression, IQuantityType)> list = new List<(TypeExpression, IQuantityType)>();
            list.Add((expression, result));
            switch(expression.Operator){                
                case TypeOperator.Multiply:                    
                    _newResult = expression.Left;
                    _newExp = new TypeExpression(result, expression.Right, TypeOperator.Divide);
                    list.Add((_newExp, _newResult));
                    _newResult = expression.Right;
                    _newExp = new TypeExpression(result, expression.Left, TypeOperator.Divide);
                    list.Add((_newExp, _newResult));
                    break;
                case TypeOperator.Divide:
                    _newResult = expression.Left;
                    _newExp = new TypeExpression(result, expression.Right, TypeOperator.Multiply);
                    list.Add((_newExp, _newResult));

                    _newExp = new TypeExpression(expression.Right, result, TypeOperator.Multiply);
                    list.Add((_newExp, _newResult));

                    _newResult = expression.Right;
                    _newExp = new TypeExpression(expression.Left, result, TypeOperator.Divide);
                    list.Add((_newExp, _newResult));
                    break;
            }
            foreach((TypeExpression, IQuantityType) entry in list){
                if(!_expressionSet.ContainsKey(entry.Item1)) 
                    _expressionSet.Add(entry.Item1, entry.Item2);
            }
        }
        internal IQuantityType getType(string name, Guid id){
            TypeId _Id = new TypeId(id, name);
            return _typeSet[_Id];
        }
        internal IQuantityType getType(TypeExpression expression){
            return _expressionSet[expression];
        }
        
        internal IQuantityType getType(string typeName){
            foreach(TypeId id in _typeSet.Keys){
                if(id.Name == typeName) return _typeSet[id]; 
            }
            throw new QuantityTypeNotExistedException("In QuantityTypeService.getType(string)");
        }

    }
}
