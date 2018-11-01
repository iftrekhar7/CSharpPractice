using PracticingCSharp.ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictator = "Hello world, i am admiral general ALADIN";
            Console.WriteLine(dictator.Shorten(4));
            Console.ReadLine();
        }
    }
}
