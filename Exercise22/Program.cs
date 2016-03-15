using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinates1 = new Coordinate();
            coordinates1.x = 1;
            coordinates1.y = 1;

            var coordinates2 = coordinates1;

            coordinates2.x = 3;
            coordinates2.y = 3;

            

            Console.WriteLine("Coordinates 1 {0}, {1}", coordinates1.x, coordinates1.y);
            Console.WriteLine("Coordinates 2 {0}, {1}", coordinates2.x, coordinates2.y);

            Console.ReadKey();
        }
    }

    struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

    }
}
