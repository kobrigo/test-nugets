using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyalNugetLib2
{
    public class EyalLibClass2
    {
        public string Foo(string textForConsole)
        {
            Console.WriteLine("EyalLibClass2:Foo");

            Console.WriteLine(textForConsole);

            return textForConsole;
        }

        public string Goo(string fileName)
        {
            Console.WriteLine("EyalLibClass2:Goo");

            Console.WriteLine("Reading file: " + fileName);

            string text = System.IO.File.ReadAllText(".\\" + fileName);
            Console.WriteLine(text);

            return text;
        }
    }
}
