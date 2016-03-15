using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19C
{
    class Program
    {
        static void Main(string[] args)
        {
            var logg = new Logger();
            var htmlLogger = new HtmlReport(logg);
            //Lagras i projektmappen ../../ :D
            Console.Write("Enter a filename to load from ( xx.txt ): ");
            while (true)
            {
                var fileName = Console.ReadLine();

                try
                {
                    logg.Load(fileName);
                    break;
                }
                catch
                {
                    Console.WriteLine("No souch file.");
                    Console.Write("Try again: ");
                }
            }

            Console.Write("Enter name of .html file to write: ");
            var htmlFile = Console.ReadLine();

            Console.WriteLine("Saving html file...");
            htmlLogger.Save(htmlFile);
            Console.WriteLine("Done!");

            Console.ReadKey();
        }
    }
}
