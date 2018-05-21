using System;
using System.Resources;
using System.IO;
using System.Xml.Linq;
using Antlr4.StringTemplate;
using System.Collections.Generic;

namespace CreateQuantityClass
{
    public  class Program
    {
        static void Main(string[] args)
        { 
            string currentdir = Directory.GetCurrentDirectory();
            DirectoryInfo groupDir = new DirectoryInfo(currentdir);
            //DirectoryInfo groupdir = dirinfo.Parent; 
            //groupdir = groupdir.Parent;
            //Console.WriteLine(groupDir.FullName);
            string templategroupfile = groupDir.FullName + "/UOM.stg";
            TemplateGroup group = new  TemplateGroupFile(templategroupfile);
            Template st = group.GetInstanceOf("quantityTypeSets");
            st.Add("QTSet", getQTs() );
            Console.WriteLine(st.Render()); 
        }

        static List<QT> getQTs(){
            string[] typeName = {
                "Identity", "Length", "Mass", 
                "Time", "ElectricCurrent", "ThermodynamicTemperature", 
                "AmountOfSubstance", "LuminousIntensity"
            };
            string[] typeName_by_base = {"Velocity", 
                "Acceleration", "Area", "Volumn", 
                "Force", "Stress"
            };

            QT[] qtps = new QT[]{
                new QT(){qtCode="1", qtName="Identity", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="2", qtName="Length", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="3", qtName="Mass", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},
                new QT(){qtCode="4", qtName="Time", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},
                            
                new QT(){qtCode="100", qtName="Velocity", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode="2", rightCode="4", op="Multiply"}}
            };

            List<QT> qts = new List<QT>();

            foreach(QT qt in qtps){qts.Add(qt);}
           
            return qts;
        }
    }
}
