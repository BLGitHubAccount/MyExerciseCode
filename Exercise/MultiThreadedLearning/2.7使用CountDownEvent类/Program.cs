using System;
using System.Threading;

namespace _2._7使用CountDownEvent类
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting two operation");
            var t1 = new Thread(()=>performOperation("operation 1 is completed",4));
            var t2 = new Thread(()=>performOperation("operation 2 is completed",8));
            t1.Start();
            t2.Start();
            _countdown.Wait();
            Console.WriteLine("Both operation have been completed.");
            _countdown.Dispose();
            Console.ReadKey();
        }

        static CountdownEvent _countdown = new CountdownEvent(2);
        static void performOperation(string message, int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine(message);
            _countdown.Signal();
        }

    }
}
