using System;
using System.Threading;

namespace _2._6使用ManualResetEventSlim
{
    class Program
    {
        static void TravelThroughGates( int seconds)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} falls to sleep");
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine($"{Thread.CurrentThread.Name}wait for the gates to open" );
            _mainEvent.Wait();
            Console.WriteLine($"{Thread.CurrentThread.Name} enter the gates");
        }

        private static ManualResetEventSlim _mainEvent = new ManualResetEventSlim(false);
        static void Main(string[] args)
        {
            var t1 = new Thread(()=>TravelThroughGates(5));
            var t2 = new Thread(()=>TravelThroughGates(6));
            var t3 = new Thread(()=>TravelThroughGates(12));
            t1.Name = "threadone";
            t2.Name = "threadtwo";
            t3.Name = "threadthree";
            t1.Start();
            t2.Start();
            t3.Start();
            Thread.Sleep(TimeSpan.FromSeconds(6));
            Console.WriteLine("the gates  are now open");
            _mainEvent.Set();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            _mainEvent.Reset();
            Console.WriteLine("the gates are now closed");
            Thread.Sleep(TimeSpan.FromSeconds(10)) ;
            Console.WriteLine("the gates are now open for the second times");
            _mainEvent.Set();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("the gates has been closed");
            _mainEvent.Reset();
            Console.ReadKey();
        }
    }
}
