using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3C
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tax = 0;

            Console.WriteLine("Enter the product name:");
            string produkt = Console.ReadLine();
            Console.WriteLine("Enter Price per unit");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the quantity bought:");
            decimal quantity = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Food item? (y/n):");
            string food = Console.ReadLine();

            if (food == "y")
            { tax = 1.1M; }
            else if (food == "n")
            {
                tax = 1.25M;
            }
            else
            {
                Console.WriteLine("The product is nothing.");
                Console.WriteLine("Press any key to quit");
                Console.ReadKey();
                return;
            }

            price *= quantity;
            decimal result = price * tax;
            decimal taxresult = result - price;
            
            Console.WriteLine();
            Console.WriteLine("---RECEIPT---");
            Console.WriteLine("Product: " + produkt);
            Console.WriteLine("Total amount to pay, excluding tax: " + price);
            Console.WriteLine("Total amount to pay, including tax: " + result);
            Console.WriteLine("Of which is tax: " + taxresult);
            Console.WriteLine("-------------");
            Console.ReadKey();



        }
    }
}
