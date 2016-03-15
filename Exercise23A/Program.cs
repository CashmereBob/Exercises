using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23A
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = new Checkbox { description = "hepp" };


        }
    }

    class Checkbox
    {
        public bool? value { get; set; }
        public string description { get; set; }


    }
}
