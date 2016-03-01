using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            var cell11 = new TableCell("CELL 1,1");
            var cell12 = new TableCell("CELL 1,2");
            var cell13 = new TableCell("CELL 1,3");

            var cell21 = new TableCell("CELL 2,1");
            var cell22 = new TableCell("CELL 2,2");

            var cell31 = new TableCell("CELL 3,1");
            var cell32 = new TableCell("CELL 3,2");
            var cell33 = new TableCell("CELL 3,3");
            var cell34 = new TableCell("CELL 3,4");
            var cell35 = new TableCell("CELL 3,5");

            var cell41 = new TableCell("CELL 4,1");

            var row1 = new TableRow(cell11);
            row1.AddCell(cell12);
            row1.AddCell(cell13);

            var row2 = new TableRow(cell21);
            

            var row3 = new TableRow(cell31);
            row3.AddCell(cell32);
            row3.AddCell(cell33);
            row3.AddCell(cell34);

            var row4 = new TableRow(cell41);

            var table = new Table();
            table.AddRow(row1);
            table.AddRow(row2);
            table.AddRow(row3);
            table.AddRow(row4);

            // Test att lägga till i lista efter att cell är fylld med filler.
            row2.AddCell(cell22);

            Console.WriteLine(table.ToString());
            Console.ReadKey();
        }
    }
}
