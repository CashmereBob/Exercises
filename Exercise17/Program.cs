using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            var logg = new Logger();
            logg.Log("Hip");
            logg.Log("Hop");
            logg.Log("Hup");
            logg.Log("Hap");

            var table = new Table();

            var enumerator = logg.GetEnumerator();
            var cellHead = new TableHeaderCell("Log Posts");
            var rowFirst = new TableRow(cellHead);
            table.AddRow(rowFirst);

            while (enumerator.MoveNext())
            {
                var cell = new TableCell(enumerator.Current);
                var row = new TableRow(cell);
                table.AddRow(row);
            }

            Console.WriteLine(table.ToString());
            Console.ReadKey();
        }
    }
}
