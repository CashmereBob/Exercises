using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class TableHeaderCell : TableCell
    {
        public TableHeaderCell(string content) : base (content)
        { }
        public override string ToString()
        {
            return string.Format("<td>{0}</td>", Content).Replace("td", "th");
        }
    }
}
