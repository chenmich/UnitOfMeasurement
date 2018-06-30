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
        private string[] _op={"Multiply", "Divide"};
        public SIQTSet(string templateGroup){
            TemplateGroup group = new  TemplateGroupFile(templateGroup);
            st = group.GetInstanceOf("quantityTypeSets");           
        }
        public  string getQTs(){
            QT[] qtps = new QT[]
            {
                new QT(){qtCode="1", qtName="Identity", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="2", qtName="Length", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="3", qtName="Mass", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="4", qtName="Time", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="5", qtName="ElectricCurrent", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="6", qtName="ThermodynamicTemperature", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="7", qtName="AmountOfSubstance", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="8", qtName="LuminousIntensity", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                new QT(){qtCode="9", qtName="Area", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="2", rightCode="2", op=_op[0]}},

                new QT(){qtCode="10", qtName="Volumn", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="2", rightCode="9", op=_op[0]}},
                
                new QT(){qtCode="11", qtName="Velocity", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="2", rightCode="4", op=_op[1]}},

                new QT(){qtCode="12", qtName="Acceleration", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="11", rightCode="4", op=_op[1]}},

                new QT(){qtCode="13", qtName="Wavenumber", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="1", rightCode="2", op=_op[1]}},
                
                new QT(){qtCode="14", qtName="MassDensity", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="3", rightCode="10", op=_op[1]}},
                
                new QT(){qtCode="15", qtName="SurfaceDensity", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="3", rightCode="9", op=_op[1]}},
                
                new QT(){qtCode="16", qtName="SpecificVolume", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="10", rightCode="3", op=_op[1]}},

                new QT(){qtCode="17", qtName="CurrentDensity", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="5", rightCode="9", op=_op[1]}},
                
                new QT(){qtCode="18", qtName="MagneticFieldStrength", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="5", rightCode="2", op=_op[1]}},
                
                new QT(){qtCode="19", qtName="AmountConcentration", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="7", rightCode="10", op=_op[1]}},

                new QT(){qtCode="20", qtName="MassConcentration",qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="3", rightCode="10", op=_op[1]}},
                
                new QT(){qtCode="21", qtName="Luminance", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="8", rightCode="9", op=_op[1]}},
                /*            
                //how to process the dimensionless quantity? 
                new QT(){qtCode="22", qtName="RefractiveIndex", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="11", rightCode="11", op=_op[1]}},
                
                new QT(){qtCode="23", qtName="RelativePermeability", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},

                */
                // i will distiguish the length between the length and radial length 
                // for plane angle, solid angle, moment of force, angular acceleration and  so on
                new QT(){qtCode="24", qtName="RadialLength", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode=null, rightCode=null, op=null}},
                
                new QT(){qtCode="25", qtName="SquareRadialLength", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="24", rightCode="24", op=_op[0]}},
                
                new QT(){qtCode="26", qtName="PlaneAngel", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="2", rightCode="24", op=_op[1]}},
                
                new QT(){qtCode="27", qtName="SolidAngle", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="9", rightCode="25", op=_op[1]}},

                new QT(){qtCode="28", qtName="Frequency", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="1", rightCode="4", op=_op[1]}},
                
                new QT(){qtCode="29", qtName="Force", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="3", rightCode="12", op=_op[0]}},
                
                new QT(){qtCode="30", qtName="Stress", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="29", rightCode="9", op=_op[1]}},

                new QT(){qtCode="31", qtName="Energy", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="29", rightCode="2", op=_op[0]}},

                new QT(){qtCode="32", qtName="Power", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="31", rightCode="4", op=_op[1]}},

                new QT(){qtCode="33", qtName="ElectricCharge", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="4", rightCode="5", op=_op[0]}},

                new QT(){qtCode="34", qtName="ElectricPotentialDifference", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="32", rightCode="5", op=_op[0]}},
                
                new QT(){qtCode="35", qtName="Capacitance", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="33", rightCode="34", op=_op[1]}},

                new QT(){qtCode="36", qtName="ElectricResistance", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="34", rightCode="5", op=_op[1]}},

                new QT(){qtCode="37", qtName="ElectricConductance", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="5", rightCode="34", op=_op[1]}},
                
                new QT(){qtCode="38", qtName="MagneticFlux", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="34", rightCode="4", op=_op[0]}},
                
                new QT(){qtCode="39", qtName="MagneticFluxDensity", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="38", rightCode="9", op=_op[1]}},
                
                new QT(){qtCode="40", qtName="Inductance", qtId=Guid.NewGuid(),
                            qtExp=new QTExpression(){leftCode="38", rightCode="5", op=_op[1]}},
                
                new QT(){qtCode="41", qtName="", qtId=Guid.NewGuid()}

                new QT(){qtCode="100", qtName="Velocity", qtId=Guid.NewGuid(), 
                            qtExp=new QTExpression(){leftCode="2", rightCode="4", op=_op[1]}}
            };

            List<QT> qts = new List<QT>();
            foreach(QT qt in qtps){qts.Add(qt);}           
            st.Add("QTSet", qts);
            return st.Render();     
        }
    }
}
