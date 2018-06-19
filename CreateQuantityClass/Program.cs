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
            string templategroupfile = groupDir.FullName + "/UOM.stg";
            SIQTSet siqts = new SIQTSet(templategroupfile);
            Console.WriteLine(siqts.getQTs());            
        }
    }
}
