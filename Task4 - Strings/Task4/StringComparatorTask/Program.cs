using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringComparatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;


            Stopwatch stopwatchForString = new Stopwatch();
            stopwatchForString.Start();

            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopwatchForString.Stop();

            TimeSpan ts = stopwatchForString.Elapsed;

            string elapsedTime = String.Format("{0}", ts.Ticks);
            Console.WriteLine("RunTime for string: " + elapsedTime);



            Stopwatch stopwatchForStringBuilder = new Stopwatch();
            stopwatchForStringBuilder.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");

            }
            stopwatchForStringBuilder.Stop();

            ts = stopwatchForStringBuilder.Elapsed;

            elapsedTime = String.Format("{0}", ts.Ticks);
            Console.WriteLine("RunTime for String Builder: " + elapsedTime);

            Console.ReadKey();
        }
    }
}
