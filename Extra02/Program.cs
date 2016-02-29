using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra02
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool[,] cell = new bool[20, 20];
            //Add some random values to the array
            Random R = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = R.Next(20);
                int y = R.Next(20);
                cell[x, y] = true;
            }

            while (true)
            {
                Console.Clear();
                game.Print(cell);
                //Process the array and get a modified array back
                cell = game.ProcessGame(cell);

                Console.ReadKey();
            }
        }
    }
}
