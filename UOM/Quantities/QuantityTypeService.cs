using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml.Linq;

[assembly: InternalsVisibleTo("UOMTest")]
namespace UOM.Quantities
{
    internal  class QuantityTypeService{
        private static readonly Dictionary<TypeExpression, IQuantityType> _typeSet
            = new Dictionary<TypeExpression, IQuantityType>();
        
        
        private static  QuantityTypeService _instance 
            = new QuantityTypeService();
        
        private QuantityTypeService(){
            XElement _typeImformation = getTypeImformation();
        }

        private XElement getTypeImformation(){
            string  current = Directory.GetCurrentDirectory();
            DirectoryInfo curinfo = new DirectoryInfo(current);
            DirectoryInfo parent = curinfo.Parent;
            parent = parent.Parent;
            parent = parent.Parent;
            parent = parent.Parent;
            Console.WriteLine("================================");
            Console.WriteLine(current);
            Console.WriteLine("==================================");
            //return XElement.Load(@".../CreateQuantityClass/QuantityType.xml");
            return new XElement("Length");
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static  QuantityTypeService getService(){
            return _instance;
        }
        
        private  IQuantityType LogType(TypeExpression expression){
            throw new NotImplementedException("QuantityTypeService.LogType");
        }
        internal IQuantityType getType(string name, Guid id){
            throw new NotImplementedException("QuantityTypeService.GetType By Name+Id");
        }
        internal IQuantityType getType(TypeExpression expression){
            throw new NotImplementedException("QuantityTypeService.GetType");
        }
        
        public IQuantityType GetBaseType(){
            throw new NotImplementedException("QuantityTypeService.GetBaseType");
        }

    }
}
