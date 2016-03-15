using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            var arrayList = new ArrayList();

            stopWatch.Restart();
            for (var i = 0; i < 10000000; i++)
            {
                arrayList.Add(i);
            }
            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);

            var list = new List<int>();

            stopWatch.Restart();
            for (var i = 0; i < 10000000; i++)
            {
                list.Add(i);
            }
            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);

            Console.ReadKey();

        }
    }
}
