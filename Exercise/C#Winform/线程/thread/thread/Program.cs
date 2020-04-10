using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mythread
{
    class Program
    {

        public static void method()
        {
            while (true)
            {
                Console.WriteLine("this is thread");
                Console.WriteLine(Thread.CurrentThread.ToString());
                Thread.Sleep(100);
            }
            

        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(method);
            Thread td = new Thread(ts);
            td.Start();
            Console.WriteLine(Thread.CurrentThread.ToString()); 
            Thread.Sleep(500);
            td.Abort();
            Console.WriteLine("thread is abort");
            Console.ReadKey();

        }
    }
}
