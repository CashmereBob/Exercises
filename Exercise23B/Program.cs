using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23B
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate? cord1 = new Coordinate() { x = 1, y = 1 };
            Coordinate? cord2 = new Coordinate() { x = 2, y = 2 };
            Coordinate? cord3 = new Coordinate() { x = 3, y = 3 };

            Triangle triangel = null;
            if (cord1 != null && cord2 != null && cord3 != null)
            {
                triangel = new Triangle(cord1, cord2, cord3);
                Console.WriteLine($"{triangel._AB.Value.x} {triangel._AB.Value.y}");
                Console.WriteLine($"{triangel._BC.Value.x} {triangel._BC.Value.y}");
                Console.WriteLine($"{triangel._CA.Value.x} {triangel._CA.Value.y}");
            }


            Console.ReadLine();
            

            

        }
    }

    struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }

    }
}
