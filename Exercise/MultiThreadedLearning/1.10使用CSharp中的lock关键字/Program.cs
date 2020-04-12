using System;
using System.Threading;

namespace _1._10使用CSharp中的lock关键字
{
    class Program
    {

        static void Test(CounterBase c)
        {
            for (int i = 0; i < 100000; i++)
            {
                c.Increase();
                c.Decrease();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("start runing...");
            var c = new CounterNoLock();
            var thread1 = new Thread(()=>Test(c));
            var thread2 = new Thread(()=>Test(c));
            var thread3 = new Thread(()=>Test(c));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            Console.WriteLine("The counter without lock:"+c.Count);
            Console.WriteLine("---------------");
            var c2 = new CounterHasLock();
            var thread4 = new Thread(()=>Test(c2));
            var thread5 = new Thread(()=>Test(c2));
            var thread6 = new Thread(() => Test(c2));
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread4.Join();
            thread5.Join();
            thread6.Join();
            Console.WriteLine("The counter have lock:"+c2.Count);

            Console.ReadKey();
        }
    }

    abstract class CounterBase
    {
        public abstract void Increase();

        public abstract void Decrease();

    }

    class CounterNoLock : CounterBase
    {
        public int Count = 0;
        public override void Decrease()
        {
            Count--;
        }

        public override void Increase()
        {
            Count++;
        }
    }

    class CounterHasLock : CounterBase
    {
        private readonly object _syncRoot = new object();
        public int Count = 0;
        public override void Decrease()
        {
            lock (_syncRoot)
            {
                Count--;
            }
           
        }

        public override void Increase()
        {
            lock (_syncRoot)
            {
                Count++;
            }
           
        }
    }


}
