using System;
using System.Threading;

namespace _1._8前台线程和后台线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start run");
            SampleThread sample1 = new SampleThread(3);
            SampleThread sample2 = new SampleThread(7);
            Thread threadOne = new Thread(sample1.run);
            Thread threadTwo = new Thread(sample2.run);
            threadOne.Name = "thread one";
            threadTwo.Name = "thread two";
            threadOne.IsBackground = true;
            threadOne.Start();
            threadTwo.Start();

            Console.WriteLine("Hello World!");
        }
    }
    class SampleThread
    {
        private int _count = 0;
        public SampleThread(int count)
        {
            this._count = count;
        }

        public void run()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Runing {i}");
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            Console.WriteLine($"{Thread.CurrentThread.Name} run end");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
