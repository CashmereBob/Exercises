using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lagras i projektmappen ../../ :D
            Console.Write("Enter a filename to save to ( xx.txt ): ");
            var fileName = Console.ReadLine();


            var logger = new Logger();

            Console.WriteLine("Enter somting to the logg or submit empty line to save and quit: ");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (input.Count() == 0)
                {
                    logger.Save(fileName);
                    break;
                }
                else
                {
                    logger.Log(input);
                }
            }
        }
    }
}
