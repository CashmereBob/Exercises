using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Exercise18
    {
        static void Main(string[] args)
        {
            Logger employeeLog = new Logger();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add employee.");
                Console.WriteLine("2. Remove employee.");
                Console.WriteLine("3. Print entire registry.");
                Console.WriteLine("4. Show filterd text.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine();
                Console.Write("Enter choise: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Employee.AddEmployee();
                        break;
                    case "2":
                        Employee.RemoveEmployee();
                        break;
                    case "3":
                        Employee.PrintEmployees();
                        break;
                    case "4":
                        Employee.SearchEmployee();
                        break;
                    case "logg":
                        Logger.PrintLog();
                        break;
                    case "5":
                        return;
                }
            }     
        }
    }
}
