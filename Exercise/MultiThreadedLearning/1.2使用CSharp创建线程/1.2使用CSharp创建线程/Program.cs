using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace _1._2使用CSharp创建线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(printfNumbers1);
            myThread.Start();
            printfNumbers2();
            
            ReadKey();
        }
        private static void printfNumbers1()
        {
            for (int i = 0; i < 9; i++)
            {
                WriteLine("thread one:"+i);

            }
        }
        private static void printfNumbers2()
        {
            for (int i = 0; i < 9; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                WriteLine("thread two:"+i);

            }
        }
    }
}
