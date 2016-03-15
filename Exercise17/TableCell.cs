using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class TableCell
    {
        public string Content { get; private set; }

        public TableCell(string content = " ")
        {
            Content = content;
        }

        public override string ToString()
        {
            return string.Format("<td>{0}</td>", Content);
        }
    }
}
