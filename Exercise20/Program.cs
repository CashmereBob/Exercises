using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            var listload = new ListLoader();
            listload.Load();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter Search");
                var input = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Result: ");

                listload.SearchLanguage(input);

                Console.WriteLine();
                Console.WriteLine("Press enter to search again or (q) to quit");
                input = Console.ReadLine();
                if (input.ToLower() == "q") { return; }

            }
        }
    }
}
