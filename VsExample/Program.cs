using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureCUI();

            Console.ReadLine();
        }

        private static void ConfigureCUI()
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Welcome to My Rocking App ****");
            Console.WriteLine("****** Edited on the tablet *******");
            Console.WriteLine("**** Re-edited on the desktop *****");
            Console.WriteLine("*** Edited again on the tablet ****");
            Console.WriteLine("***********************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
