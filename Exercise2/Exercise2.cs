using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Were do you work {0}?", name);
            string jobb = Console.ReadLine();
            Console.WriteLine("So {0}, how old are you?", name);
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Whats you jobtitle {0}?", name);
            string title = Console.ReadLine();

            int year = DateTime.Today.Year - age;

            string str = string.Format("Hello {0}!\nYou are {1}, wich means you were born in {2}. You work at {3}, where \"{4}\" is your title.", name, age, year, jobb, title);
            Console.WriteLine(str);
           
            Console.ReadKey();

        }
    }
}
