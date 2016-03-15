using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19C
{
    class Table
    {
        
        private List<TableRow> _rows;
        int _masterNumberOfCells = 0;

        public Table()
        {
            _rows = new List<TableRow>();
            
        }

        public void AddRow(TableRow row)
        {
            
            _rows.Add(row);
            MasterCellCount();

        }
        public void AddCol(int cols = 1)
        {

            _masterNumberOfCells += cols;
            MasterCellCount();

        }
        public void MasterCellCount()
        {
            
            foreach (TableRow row in _rows)
            {
                if (_masterNumberOfCells < row._numberOfCells)
                { _masterNumberOfCells = row._numberOfCells;
                    
                }
                row._masterCellCount = _masterNumberOfCells;
                row.CellFill();
            }

            
        }

        public override string ToString()
        {
            var rowString = new StringBuilder(); 
            foreach (TableRow row in _rows)
            {
                rowString.Append(row.ToString());
            }
            var rows = rowString.ToString();

            return string.Format("<table>{0}</table>", rows);
        }

    }
}
