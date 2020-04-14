using System;
using System.Threading;

namespace _1._11使用Monitor类锁定资源
{
    class Program
    {
        private static readonly object _lockA = new object();

        private static readonly object _lockB=new object();


        static void Main(string[] args)
        {
            //一下代码可以设置超时解决死锁

            new Thread(()=>CreateDeadLock()).Start();
            lock (_lockB)
            {
                Console.WriteLine("我是B我要锁A，如果等待2s未获得A的锁就不等了。。");
                if (Monitor.TryEnter(_lockA, TimeSpan.FromSeconds(2)))
                {
                    Console.WriteLine("活得锁A使用权");
                }
                else
                {
                    Console.WriteLine("等待超时");
                }
                
            }
            


            /////以下代码会造成死锁
            //new Thread(() => CreateDeadLock()).Start();          
            //lock (_lockB)
            //{

            //    Console.WriteLine("我是B我要锁A");
            //    lock (_lockA)
            //    { 
            //        Console.WriteLine("看不到这条消息说明死锁了");
            //    }
            //}
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        static void CreateDeadLock()
        {
            lock (_lockA)
            {
                Thread.Sleep(500);
                Console.WriteLine("我是A我要锁B");
                lock (_lockB)
                {
                    Console.WriteLine("看不到这条消息说明死锁了");
                }
            }
        }
    }
}
