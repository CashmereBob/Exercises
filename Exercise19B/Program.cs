using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19B
{
    class Program
    {
        static void Main(string[] args)
        {
            var logg = new Logger();
            //Lagras i projektmappen ../../ :D
            Console.Write("Enter a filename to load from ( xx.txt ): ");
            while (true)
            {
                var fileName = Console.ReadLine();

                try {
                    logg.Load(fileName);
                    break;
                }
                catch
                {
                    Console.WriteLine("No souch file.");
                    Console.Write("Try again: ");
                }
            }
            foreach (string post in logg)
            {
                Console.WriteLine(post);
            }

            Console.ReadKey();
        }
    }
}
