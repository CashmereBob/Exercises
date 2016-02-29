using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra02
{
    class Game
    {
        public void Print(bool[,] cell)
        {
            var xmax = cell.GetUpperBound(0);
            var ymax = cell.GetUpperBound(1);

            
            for (int row = 0; row <= xmax; row++)
                {
                    for (int col = 0; col <= ymax; col++)
                        {
                            Console.Write(cell[row,col] ? "*" : " ");
                        }
                Console.Write("\n");
            }
   
        }
        public int CountNeighbours(int row, int col, bool[,] cell)
        {
            int count = 0;

            var xmax = cell.GetUpperBound(0);
            var ymax = cell.GetUpperBound(1);


                        if (row > 0 && col > 0 && cell[row - 1, col - 1] == true){ count++; }
                        if (row > 0 && cell[row - 1, col] == true){ count++; }
                        if (row > 0 && col < ymax && cell[row - 1, col + 1] == true){ count++; }

                        if (col > 0 && cell[row, col - 1] == true){ count++; }
                        if (col < ymax && cell[row, col + 1] == true){ count++; }

                        if (row < xmax && col > 0 && cell[row + 1, col - 1] == true) { count++; }
                        if (row < xmax && cell[row + 1, col] == true){ count++; }
                        if (row < xmax && col < ymax && cell[row + 1, col + 1] == true){ count++; }

            return count;
        }
        public bool[,] ProcessGame(bool[,] cell)
        {
            var xmax = cell.GetUpperBound(0);
            var ymax = cell.GetUpperBound(1);

            for (int row = 0; row <= xmax; row++)
            {
                for (int col = 0; col <= ymax; col++)
                {
                    if (cell[row, col] == true && CountNeighbours(row, col, cell) < 2 ) { cell[row, col] = false; }
                    if (cell[row, col] == true && CountNeighbours(row, col, cell) > 3) { cell[row, col] = false; }
                    if (cell[row, col] == true && CountNeighbours(row, col, cell) == 2) { cell[row, col] = true; }
                    if (cell[row, col] == true && CountNeighbours(row, col, cell) == 3) { cell[row, col] = true; }
                    if (cell[row, col] == false && CountNeighbours(row, col, cell) == 3) { cell[row, col] = true; }
                }
            }
            return cell;
        }
    }
}
