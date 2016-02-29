using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Employee
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string socialSecurityNumber = string.Empty;
        private int hourlyWage = 0;
     

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

        public string FullName
        {
            get { return string.Format(this.firstName + " " + this.lastName); }
        }

    }
}
