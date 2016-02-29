using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Exercise3A
    {
      
        static void Main(string[] args)
        {
            ulong summa = 0;
            bool success = false;

            while (success == false)
            {
                Console.WriteLine("Enter a positive integer.");
                ulong tal = 0;
                try
                {
                    tal = ulong.Parse(Console.ReadLine());
                    success = true;
                }
                catch
                {
                    Console.WriteLine("That was not a positive integer.");
                }

                if (success == true)
                {
                    for (ulong i = 1; i <= tal; i++)
                    {
                        if (i == tal)
                        {
                            Console.Write(i);
                        }
                        else {
                            Console.Write(i + "+");
                        }
                        summa += i;
                    }
                    Console.Write(" = ");
                    Console.WriteLine(summa);
                }
            }
            Console.ReadKey();
        }
    }
}
