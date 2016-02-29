using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            Console.Write("Enter year of birth ( 19xx ): ");
            var year = int.Parse(Console.ReadLine());
            Console.Write("Enter month of birth: ");
            var month = int.Parse(Console.ReadLine());
            Console.Write("Enter day of birth: ");
            var day = int.Parse(Console.ReadLine());

            var then = new DateTime(year, month, day);
            var today = DateTime.UtcNow;

            var age = today.Year - then.Year;

            if (today < then.AddYears(age)) age--;

            var next = new DateTime(today.Year, then.Month, then.Day);

            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;

            var hundra = new DateTime(then.Year + 100, then.Month, then.Day);

            Console.WriteLine();
            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine("You are {0} years old, and will turn {1} in {2} days. Your 100th birthday will be on a {3}.", age, age + 1, numDays, hundra.DayOfWeek);

            Console.ReadKey();


        }
    }
}
