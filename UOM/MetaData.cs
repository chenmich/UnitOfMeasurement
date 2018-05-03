using System;

namespace UOM
{
    public static class MetaData
    {
        public static readonly string[] baseTypeName = 
            {"Length","Mass", "Time", "Electric Current",
                "Thermodynamic Temperature", "Tmount of Substance",        
                "Luminous Intensity", "Identity"};

        public static readonly string[]  baseUnitName = {
            "meter", "kilograme", "second", 
            "ampere", "kelvin", "mole","candela", ""
        };

        public static readonly string[] baseUnitSymbol = {
            "m", "kg", "s", "A", "K", "mole", "cd", ""
        };
    }
}
