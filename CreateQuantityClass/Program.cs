using System;
using System.Resources;
using System.Xml.Linq;
using Antlr4.StringTemplate;

namespace CreateQuantityClass
{
    public  class Program
    {
        static void Main(string[] args)
        {
            string[] typeName = {
                "Identity", "Length", "Mass", 
                "Time", "ElectricCurrent", "ThermodynamicTemperature", 
                "AmountOfSubstance", "LuminousIntensity", "Velocity", 
                "Acceleration", "Area", "Volumn", 
                "Force", "Stress"
            };
            TemplateGroup group = new TemplateGroupString(@"s(x)::= << <x.x> + <y(x.y)> >>
                                                            y(z)::=<< <z> >>");
            Template st = group.GetInstanceOf("s");
            some x = new some();
            x.x = 5;
            x.y = 6;
            st.Add("x", x);
            Console.WriteLine(st.Render());           
            
        }
    }
    public struct some{
        public float x;
        public float y;
    }
}
