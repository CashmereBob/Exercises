using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Logger
    {
        private static List<string> logPosts = new List<string>();
        public static void Log(string message)
        {
            // Add the message to a private List<string>
            logPosts.Add(message);
        }

        public static void PrintLog()
        {
            Console.Clear();
            Console.WriteLine("Logg: ");
            Console.WriteLine();
            foreach (string post in logPosts)
            { Console.WriteLine(post); }
            Console.WriteLine();
            Console.Write("Press any key to go back.");
            Console.ReadKey();

        }

    }
}
