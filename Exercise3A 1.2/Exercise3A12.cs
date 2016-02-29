using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3A_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong val = 0;
            ulong summa = 0;
            ulong count = 0;
            List<ulong> varden = new List<ulong>();

            Console.Write("Enter a positive integer: ");
            while (true)
            {
                try
                {
                    val = ulong.Parse(Console.ReadLine());
                    break;
                }
                catch { Console.WriteLine("Try again"); }
            }
            Console.WriteLine();
            Console.WriteLine("The for loop.");
            for (ulong i = 1; i <= val; i++)
            {
                if (i == val)
                { Console.Write(i); }
                else
                {
                    Console.Write(i + "+");
                }
                varden.Add(i);
                summa += i; }

            Console.WriteLine(" = " + summa);
            Console.WriteLine();
            Console.WriteLine("The while loop.");

            summa = 0;
            ulong a = 1;

            while (a <= val)
            {
                if (a == val)
                { Console.Write(a); }
                else
                {
                    Console.Write(a + "+");
                }
                summa += a;
                a++;
            }
            Console.WriteLine(" = " + summa);
            Console.WriteLine();

            Console.WriteLine("The do while loop.");

            summa = 0;
            ulong b = 1;

            do
            {
                if (b == val)
                { Console.Write(b); }
                else
                {
                    Console.Write(b + "+");
                }
                summa += b;
                b++;
            } while (b <= val);
            Console.WriteLine(" = " + summa);
            Console.WriteLine();

            Console.WriteLine("The for each loop");
            summa = 0;

           

            foreach (ulong num in varden)
            {
                count++;
                if (count == val)
                {
                    Console.Write(num);
                }
                else {
                    Console.Write(num + "+");
                }
                
                summa += num;
            }

            Console.WriteLine(" = " + summa);



            Console.ReadLine();
        }
        
    }
}
