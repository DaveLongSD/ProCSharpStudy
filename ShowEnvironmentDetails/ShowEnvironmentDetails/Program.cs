using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowEnvironmentDetails
{
    class Program
    {
        static int Main(string[] args)
        {
            ConsoleHelloWorld();
            
            // Helper method within the Program class.
            ShowEnvironmentDetails();

            Console.ReadLine();            
            return -1;
        }

        private static void ConsoleHelloWorld()
        {
            Console.WriteLine("***** My First C# App ***** ");
            Console.WriteLine("Hello World");
            Console.WriteLine();
        }

        static void ShowEnvironmentDetails()
        {
            //Print out the drives on this machine
            //and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net version: {0}", Environment.Version);

        }

    }
}
