using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class LogApplication
    {
        ILogger _logger = null;

        public LogApplication (ILogger _logger) : base()
        {
            this._logger = _logger;
        }

        public void Run()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add message log");
                Console.WriteLine("2. Print Log");
                Console.WriteLine();
                Console.Write("Choise: ");
                var input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        Console.Write("Message: ");
                        var logMessage = Console.ReadLine();
                        _logger.Log(logMessage);
                        break;
                    case "2":
                        foreach (string log in _logger.LogPosts)
                        { Console.WriteLine(log); }

                        break;
                    case "3":
                        return;
                }
            }
        }
    }
}
