using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class LogApplication
    {
        ILogger log = null;

        public LogApplication (ILogger _log) : base()
        {
            this.log = _log;
        }

        public void Run()
        {
            Console.WriteLine("1. Add message log");
            Console.WriteLine("2. Print Log");
            Console.WriteLine();
            Console.Write("Choise: ");

            while (true)
            {
                var input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        Console.Write("Message: ");
                        var logMessage = Console.ReadLine();
                        log.Log(logMessage);
                        break;
                    case "2":
                        foreach (string log in log.LogPosts)
                        { Console.WriteLine(log); }

                        break;
                    case "3":
                        return;
                }
            }
        }
    }
}
