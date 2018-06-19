using System;
using System.Collections.Generic;
using Antlr4.StringTemplate;
using System.IO;


namespace CreateQuantityClass
{
    public class QT
    {
        public string qtCode;
        public string qtName;
        public Guid qtId;
        public QTExpression qtExp;
    }
    public class QTExpression
    {
        public string leftCode;
        public string rightCode;
        public string op;
    }

    public class SIQTSet
    {
        private Template st;
        public SIQTSet(string templateGroup){
            TemplateGroup group = new  TemplateGroupFile(templateGroup);
            st = group.GetInstanceOf("quantityTypeSets");           
        }
        public  string getQTs(){
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
            st.Add("QTSet", qts);
            return st.Render();     
        }
    }

}
