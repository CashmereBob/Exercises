using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtraMod4._2_string_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Input("Insert a sting");
            Console.ReadLine();

        }

        static void Input(string text)
        {
            
            while (true)
            {
                string ioStatus = string.Empty;
                Console.Write(text + ": ");
                var output = new StringBuilder();

                var input = Console.ReadLine();

                if (input.Count() > 5)
                {
                    output.Append("Larger then 5.\n");
                } else
                {
                    output.Append("Smaler then 5.\n");
                }

                if (input.Count() > 4 && input.Count() < 8)
                {
                    output.Append("Larger then 4 and lesser then 8.\n");
                }
                else
                {
                    output.Append("Not larger then 4 or lesser then 8.\n");
                }

                if (char.IsNumber(input[0]) && char.IsNumber(input[1]))
                {
                    output.Append("The first to chars is integers.\n");
                }
                else
                {
                    output.Append("The first two chars is not integers.\n");
                }

                if (input.Contains("borg"))
                {
                    output.Append("Input contains the string borg.\n");
                }
                else
                {
                    output.Append("Input do not contain the string borg.\n");
                }

                int length = input.Count() - 1;
                if (input[length] == ':')
                    {
                        output.Append("Input ends with :.\n");
                    }
                    else
                    {
                        output.Append("Input do not end with :.\n");
                    }

                var str = new StringBuilder();
                foreach (char ch in input)
                {
                    str.Append(ch);
                }
                string newStr = str.ToString();
                newStr = newStr.ToUpper();

                if (input == newStr)
                    {
                        output.Append("All chars is upper case.\n");
                    }
                    else
                    {
                        output.Append("Not all chars is upper case.\n");
                    }

                if (input.Contains('(') == true && input.Contains(')') == true && input.IndexOf('(') < input.IndexOf(')'))


                {
                    output.Append("Correct use of ( ).\n");
                }
                else
                {
                    output.Append("No ( ) or incorrekt use of ( ).\n");
                }


                if (input.Contains("+46") && input.IndexOf("+46") == 0)
                { input = input.Remove(0, 3); }

                input = input.Replace(".", "");

                output.Append("\n" + "New number: " + input);

                var input2 = input.Split(',');
                var input3 = new StringBuilder();
                if (input2.Length < 0)
                {
                    foreach (string num in input2)
                    {
                        if (num[0] != '-') { input3.Append(num + ','); }
                    }

                    input3.Remove(input3.Length - 2, input3.Length - 1);
                    input = input3.ToString();
                }

                if (input[input.Count() - 1] != '.')
                { input = input + '.'; }

                output.Append("\n" + "String without negative numbers and end . : " + input);


                string newOutput = output.ToString();
               
                Console.WriteLine(newOutput);
                Console.WriteLine();

            }


        }
    }
}
