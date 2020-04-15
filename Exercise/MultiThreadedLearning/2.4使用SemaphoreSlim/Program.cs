using System;
using System.Threading;

namespace _2._4使用SemaphoreSlim
{
    class Program
    {
        private static SemaphoreSlim semaphore = new SemaphoreSlim(1);
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                int seconds = 2+i * 2;
                Thread t = new Thread(()=>AccessDataBase(seconds));
                t.Name = i.ToString();
                t.Start();
            }

           
            Console.ReadKey();
        }

        static void AccessDataBase(int seconds)
        {
            Console.WriteLine($"线程{Thread.CurrentThread.Name}等待获得数据库访问权..");
            semaphore.Wait();
            Console.WriteLine($"线程{Thread.CurrentThread.Name}获得数据库访问权");
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
            Console.WriteLine($"线程{Thread.CurrentThread.Name}释放访问权");
            semaphore.Release();
        }
    }
}
