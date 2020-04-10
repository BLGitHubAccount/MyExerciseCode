using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace _1._6检测线程状态
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("starting...");
            Thread td = new Thread(printfNumbers1);
            Thread td2 = new Thread(printfNumbers1);
            
            WriteLine("td thread status:"+td.ThreadState.ToString()); 
            td.Start();
            td2.Start();
            
            WriteLine("td thread status:" + td.ThreadState.ToString());
            WriteLine("td2 thread status:" + td2.ThreadState.ToString());
            Thread.Sleep(TimeSpan.FromSeconds(3));
            td.Abort();
            WriteLine("td thread status:" + td.ThreadState.ToString());
            WriteLine("a thread had been abort!");
            td2.Join();
            WriteLine("td2 thread status:"+td2.ThreadState.ToString());
            WriteLine("program complete!!");
            ReadKey();
        }

        private static void printfNumbers1()
        {
            WriteLine("td thread status :" + Thread.CurrentThread.ThreadState.ToString());
            for (int i = 0; i < 9; i++)
            {
                WriteLine("thread one:" + i);
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
        }
        private static void printfNumbers2()
        {
            WriteLine("td2 thread status :" + Thread.CurrentThread.ThreadState.ToString());
            for (int i = 0; i < 9; i++)
            {
                WriteLine("thread one:" + i);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
