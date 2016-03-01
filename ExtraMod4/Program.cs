using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraMod4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = 10;
            var htmlOutput = new StringBuilder();

            htmlOutput.Append("<table>\n");

            for (int i = 1; i <= rows; i++)
            {
                if (i % 2 == 0){ htmlOutput.Append(" <tr>\n");}
                else { htmlOutput.Append(" <tr bgcolor=\"#CCCCCC\">\n"); }

                htmlOutput.Append("     <td>Row" + i + "</td>\n");
                htmlOutput.Append("     <td>xxxxx</td>\n");
                htmlOutput.Append(" </tr>\n");
            }

            htmlOutput.Append("</table>\n");

            string html = htmlOutput.ToString();

            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}
