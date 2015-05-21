using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecifyingAnApplicationErrorCode
{
    class Program
    {
        static int Main(string[] args)
        {
            ConsoleHelloWorld();

            //Wait for Enter Key to be pressed before shutting down.
            Console.ReadLine();

            return -1;
        }

        private static void ConsoleHelloWorld()
        {
            Console.WriteLine("***** My First C# App ***** ");
            Console.WriteLine("Hello World");
            Console.WriteLine();
        }
    }
}
