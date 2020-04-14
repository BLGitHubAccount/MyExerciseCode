using System;
using System.Threading;

namespace _1._12处理异常
{
    class Program
    {
        static void Main(string[] args)
        {
            //线程外部无法获取线程内抛出的异常
            try
            {
                new Thread(() =>
                {
                    BadFaultyThread();
                }).Start();
            }
            catch (Exception ex)
            {

                Console.WriteLine("badFaultyThread exception");
            }

            new Thread(()=> 
            {
                FaultyThread();
            }).Start();


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void BadFaultyThread()
        {
            try
            {
                Console.WriteLine("我是抛出异常的线程");
                Thread.Sleep(TimeSpan.FromSeconds(2));

                throw new Exception("Boom!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"badFaultException {ex.Message}");
            }

        }

        static void FaultyThread()
        {
            try
            {
                Console.WriteLine("我是处理异常的线程");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                throw new Exception("Boom!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"捕获线程FaultyThread信息{ex.Message}");
            }

        }
    }
}
