using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
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
                Console.Write("Enter from year: ");
                var inputone = int.Parse(Console.ReadLine());

                Console.Write("Enter to year: ");
                var inputtwo = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Result: ");

                listload.SearchLanguage(inputone, inputtwo);

                Console.WriteLine();
                Console.WriteLine("Press enter to search again or (q) to quit");
                string input = Console.ReadLine();
                if (input.ToLower() == "q") { return; }

            }
        }
    }
}
