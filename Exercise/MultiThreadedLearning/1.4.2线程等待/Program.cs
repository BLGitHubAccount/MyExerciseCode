using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace _1._4._2线程等待
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread td = new Thread(printfNumbers1);
            td.Start();
            td.Join();
            WriteLine("program complete!!");
            ReadKey();
        }

        private static void printfNumbers1()
        {
            for (int i = 0; i < 9; i++)
            {
                WriteLine("thread one:" + i);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
