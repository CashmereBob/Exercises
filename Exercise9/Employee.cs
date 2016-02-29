using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Employee
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string socialSecurityNumber = string.Empty;
        private int hourlyWage = 0;
        private static List<Employee> employees = new List<Employee>();

        public string FullName
        {
            get { return string.Format(this.firstName + " " + this.lastName); }
        }

        public string SocialSecurityNumber{
                get { return socialSecurityNumber; }
        }

    public Employee(string firstName, string lastName, string socialSecurityNumber, int hourlyWage )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
            this.hourlyWage = hourlyWage;
           
        }

        public Employee(string socialSecurityNumber)
        {
            this.socialSecurityNumber = socialSecurityNumber;
        }

        public static  void AddEmployee()
        {
            Console.Clear();
            Console.Write("First name: ");
            var fname = Console.ReadLine();
            Console.Clear();
            Console.Write("Last name: ");
            var lname = Console.ReadLine();
            Console.Clear();
            Console.Write("Social security number ( xxxxxx-xxxx ): ");
            string ssn = Console.ReadLine();
            bool isNum = true;

            while (true)
            {
                foreach (char num in ssn)
                {
                    if (Char.IsNumber(num) == false && num != '-')
                    {
                        isNum = false;
                        break;
                    }
                    else {
                        isNum = true;
                    }
                }

                if (ssn.Count<char>() == 11 && ssn[6] == char.Parse("-") && isNum == true)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Format, try again.");
                    Console.Write("Social security number ( xxxxxx-xxxx ): ");
                    ssn = Console.ReadLine();
                    
                }

            }

            Console.Clear();
            Console.Write("Hourly wage: ");
            string input = Console.ReadLine();
            int wage = 0;
            while (true)
            {
                try {
                    wage = int.Parse(input);
                    break;
                } catch
                {
                    Console.Clear();
                    Console.WriteLine("Wrong format, try again.");
                    Console.Write("Hourly wage: ");
                    input = Console.ReadLine();
                }   
            }

       
            if (fname.Count<char>() == 0 )
            { Employee employee = new Employee(ssn);
                employees.Add(employee);
                string output = DateTime.Now.ToString() + " ** ADD ** " + employee.SocialSecurityNumber;
                Logger.Log(output);
            }
            else
            {
                Employee employee = new Employee(fname, lname, ssn, wage);
                employees.Add(employee);
                string output = DateTime.Now.ToString() + " ** ADD ** " + employee.FullName + " SSN: " + employee.SocialSecurityNumber;
                Logger.Log(output);
            }



        }

        public static void RemoveEmployee()
        {
            Employee remove = null;
            Console.Clear();
            Console.Write("Social security number of employee to remove ( xxxxxx-xxxx ): ");
            var input = Console.ReadLine();

            foreach (Employee emp in employees)
            {
                if (input == emp.SocialSecurityNumber)
                { remove = emp;  }
            }

            if (remove == null)
            {
                Console.Clear();
                Console.WriteLine("No matching employee found.");
                Console.WriteLine();
                Console.Write("Press any key to go back. ");
                Console.ReadKey();
            }
            else
            {
                employees.Remove(remove);
                string output = DateTime.Now.ToString() + " ** REMOVE ** " + remove.FullName + " SSN: " + remove.SocialSecurityNumber;
                Logger.Log(output);

                Console.Clear();
                Console.WriteLine("Employee matching search found and removed.");
                Console.WriteLine();
                Console.Write("Press any key to go back. ");
                Console.ReadKey();

            }

        }

        public static void PrintEmployees()
        {
            if (employees.Count() == 0)
            {
                Console.Clear();
                Console.WriteLine("Registry of employees is empty.");
                Console.WriteLine();
                Console.Write("Press any key to go back");
                Console.ReadKey();
            }
            else {
                Console.Clear();
                Console.WriteLine("Employees:");

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee.FullName + ", SSN: " + employee.SocialSecurityNumber + ", " + employee.hourlyWage + " kr/h");
                }

                Console.WriteLine();
                Console.Write("Press any key to go back");
                Console.ReadKey();
            }
        }

        public static void SearchEmployee()
        {
            Employee found = null;
            Console.Clear();
            Console.Write("Search employee based on year of birth: ");
            var input = Console.ReadLine();

            foreach (Employee emp in employees)
            {
                
                if (emp.SocialSecurityNumber.StartsWith(input) == true)
                {
                    Console.WriteLine(emp.FullName + ", SSN: " + emp.SocialSecurityNumber + ", " + emp.hourlyWage + " kr/h");
                    found = emp; }
            }

            if (found == null)
            {
                Console.Clear();
                Console.WriteLine("No matching employee found.");
                Console.WriteLine();
                Console.Write("Press any key to go back. ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.Write("Press any key to go back. ");
                Console.ReadKey();

            }

        }

    }
}
