using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyalNugetLib1
{
    public class EyalLibClass1
    {
        public string Foo(string textForConsole)
        {
            Console.WriteLine("EyalLibClass1:Foo");

            Console.WriteLine(textForConsole);
            
            return textForConsole;
        }

        public string Goo(string fileName)
        {
            Console.WriteLine("EyalLibClass1:Goo");

            Console.WriteLine("Reading file: " + fileName);

            string text = System.IO.File.ReadAllText(".\\" + fileName);
            Console.WriteLine(text);

            return text;
        }
    }
}
