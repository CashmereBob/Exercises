using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19C
{
    class HtmlReport : ISaveable
    {
        ILogger _logg;
        public HtmlReport(ILogger logg)
        {
            this._logg = logg;
        }

        public void Save(string fileName)
        {
            var myWriter = new StreamWriter(@"../../" + fileName + ".html");
            
            
            myWriter.WriteLine(ToString());
            
            myWriter.Close();

        }

        public override string ToString()
        {
            var table = new Table();
            var cellHead1 = new TableHeaderCell("Entry");
            var cellHead2 = new TableHeaderCell("Log content");
            
            var rowFirst = new TableRow(cellHead1);
            rowFirst.AddCell(cellHead2);

            table.AddRow(rowFirst);

            int counter = 1;
            foreach (string post in _logg)
            {
                var cell1 = new TableCell("#" + counter);

                var cell2 = new TableCell(post);
                var row = new TableRow(cell1);

                row.AddCell(cell2);

                table.AddRow(row);
                counter++;
            }

            return string.Format("<html><body>{0}</body><html>", table);
        }
    }
}
