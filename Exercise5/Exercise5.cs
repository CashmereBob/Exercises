using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Jonny", "Nilsson", "19651212 - 3939", 300);
            Employee emp2 = new Employee("Conny", "Andersson", "19651212 - 3939", 300);
            Employee emp3 = new Employee("Leif", "Hansson", "19651212 - 3939", 300);
            Employee emp4 = new Employee("Ronny", "Svensson", "19651212 - 3939", 300);
            Employee emp5 = new Employee("19881212-3838");

            Console.WriteLine(emp1.FullName);
            Console.WriteLine(emp2.FullName);
            Console.WriteLine(emp3.FullName);

            Console.ReadKey();


        }
    }
}
