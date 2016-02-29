using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3B
{
    class Exercise3B
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an operator");
            Console.WriteLine("------------------");
            Console.WriteLine("A. Addition (+)");
            Console.WriteLine("B. Subtraction (-)");
            Console.WriteLine("C. Multiplication (*)");
            Console.WriteLine("D. Division (/)");
            Console.WriteLine();

            bool count = false;
            decimal tal1 = 0;
            decimal tal2 = 0;
            decimal result = 0;

            while (count == false)
            {
                string caseSwitch = Console.ReadLine().ToUpper();
                switch (caseSwitch)
                {
                    case "A":
                        Console.WriteLine("Choise: " + caseSwitch);
                        Console.Write("Enter the first number: ");
                        try { tal1 = decimal.Parse(Console.ReadLine()); }
                        catch { Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }
                        Console.Write("Enter the first number: ");
                        try { tal2 = decimal.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }

                        result = tal1 + tal2;
                        Console.WriteLine("Result " + result);
                        count = true;

                        break;
                    case "B":
                        Console.WriteLine("Choise: " + caseSwitch);
                        Console.Write("Enter the first number: ");
                        try { tal1 = decimal.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }
                        Console.Write("Enter the first number: ");
                        try { tal2 = decimal.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }

                        result = tal1 - tal2;
                        Console.WriteLine("Result " + result);
                        count = true;

                        break;
                    case "C":
                        Console.WriteLine("Choise: " + caseSwitch);
                        Console.Write("Enter the first number: ");
                        try { tal1 = decimal.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }
                        Console.Write("Enter the first number: ");
                        try { tal2 = decimal.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }

                        result = tal1 * tal2;
                        Console.WriteLine("Result " + result);
                        count = true;

                        break;
                    case "D":
                        Console.WriteLine("Choise: " + caseSwitch);
                        Console.Write("Enter the first number: ");
                        try { tal1 = decimal.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }
                        Console.Write("Enter the first number: ");
                        try { tal2 = decimal.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("Not Correct format");
                            Console.WriteLine("Select an operator");
                            break;
                        }

                        result = tal1 / tal2;
                        Console.WriteLine("Result " + result);
                        count = true;

                        break;
                    default:
                        Console.WriteLine("That is not a valid choise");
                        break;
                }

                if (count == true)
                {

                    Console.WriteLine("Do you want to make another calculation ? (y / n)");
                    string caseSwitch2 = Console.ReadLine().ToUpper();
                    switch (caseSwitch2)
                    {
                        case "Y":
                            Console.WriteLine("Select an operator");
                            Console.WriteLine("------------------");
                            Console.WriteLine("A. Addition (+)");
                            Console.WriteLine("B. Subtraction (-)");
                            Console.WriteLine("C. Multiplication (*)");
                            Console.WriteLine("D. Division (/)");
                            Console.WriteLine();
                            count = false;
                            break;
                        default:
                            Console.WriteLine("Press any key to quit.");
                            Console.ReadKey();
                            break;
                    }


                }
            }
        }
    }
}
