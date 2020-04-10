using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace _1._5._3终止线程_不推荐_
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread td = new Thread(printfNumbers1);
            td.Start();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            td.Abort();
            WriteLine("a thread had been abort!");

            //WriteLine("program complete!!");
            ReadKey();
        }

        private static void printfNumbers1()
        {
            for (int i = 0; i < 9; i++)
            {
                WriteLine("thread one:" + i);
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }
    }
}
