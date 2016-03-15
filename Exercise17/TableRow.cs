using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class TableRow
    {
        private List<TableCell> _cell;
        public int _numberOfCells { get; private set; }
        public int _masterCellCount { get; set; }
        public TableRow(TableCell cell)
        { 
            _cell = new List<TableCell>();
            _cell.Add(cell);
            _numberOfCells = 0;
            _numberOfCells++;

        }


        public void AddCell(TableCell cell)
        {
            
            int index = 0;
            if (_masterCellCount == _numberOfCells)
            {

                foreach (TableCell curCell in _cell)
                {
                    if (curCell.Content.Count() == 1)
                    {
                        _cell[index] = cell;
                        break;
                    }
                    index++;
                }
                

                
                
            }else {
                _cell.Add(cell);
                _numberOfCells++;
            }
            


        }

        public override string ToString()
        {
            var cellString = new StringBuilder();
            foreach (TableCell cell in _cell)
            {
                cellString.Append(cell.ToString());
            }
            var cells = cellString.ToString();

            return string.Format("<tr>{0}</tr>", cells);
        }
        public void CellFill()
        {
            int cellsToFill = _masterCellCount - _numberOfCells;
            for (int i = 0; i < cellsToFill; i++)
            {
                var fillCell = new TableCell();
                _cell.Add(fillCell);
                _numberOfCells++;
            }
        }
    }
}
