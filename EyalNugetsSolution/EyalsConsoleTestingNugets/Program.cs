using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyalNugetLib1;
using EyalNugetLib2;

namespace EyalsConsoleTestingNugets
{
    class Program
    {
        static void Main(string[] args)
        {
            EyalLibClass1 eyalLibClass1 = new EyalLibClass1();
            eyalLibClass1.Foo("text for Foo in EyalLibClass1");

            EyalLibClass2 eyalLibClass2 = new EyalLibClass2();
            eyalLibClass2.Foo("text for Foo in EyalLibClass2");

            Console.ReadLine();
        }
    }
}
