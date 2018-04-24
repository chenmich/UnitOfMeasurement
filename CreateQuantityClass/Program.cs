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
            
        }
    }
}
