using System;
using System.Threading;

namespace _2._2执行基本的原子操作
{
    class Program
    {

        static void Main(string[] args)
        {
            var c = new CounterNoLock();
            var t = new Thread(()=> Testc(c));
            var t2 = new Thread(() => Testc(c));
            var t3 = new Thread(() => Testc(c));
            t.Start();
            t2.Start();
            t3.Start();
            t.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine($"counter:{c.Count}");
            Console.WriteLine("-------------------");
            var c2 = new Counter();
            t = new Thread(() => Testc(c2));
            t2 = new Thread(() => Testc(c2));
            t3 = new Thread(() => Testc(c2));
            t.Start();
            t2.Start();
            t3.Start();
            t.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine($"Counter:{c2.Count}");
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void Testc(CounterBase c)
        {
            for (int i = 0; i < 10000; i++)
            {
                c.Increase();
                c.Decrease();
            }
        }

        abstract class CounterBase
        {
            public abstract void Increase();

            public abstract void Decrease();
        }

        class CounterNoLock:CounterBase
        {
            private int _count;
            public int Count => _count;
            public override void Increase()
            {
                _count++;
            }
            public override void Decrease()
            {
                _count--;
            }
        }

        class Counter : CounterBase
        {
            private int _count;
            public int Count => _count;
            public override void Increase()
            {
                Interlocked.Increment(ref _count);
            }
            public override void Decrease()
            {
                Interlocked.Decrement(ref _count);
            }
        }

    }
}
