using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace _3._4线程池与并行度
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfoperations = 5000;
            var sw = new Stopwatch();
            sw.Start();
            UseThreads(numberOfoperations);
            sw.Stop();
            Console.WriteLine($"Execution time using threads:{sw.ElapsedMilliseconds}");

            sw.Reset();
            sw.Start();
            UseThreads(numberOfoperations);
            sw.Stop();
            Console.WriteLine($"Execution time using threads:{sw.ElapsedMilliseconds}");
            Console.ReadKey();
        }
        static void UseThreads(int numberofOperations)
        {
            using (var countdown=new CountdownEvent(numberofOperations))
            {
                Console.WriteLine("线程调度");
                for (int i = 0; i < numberofOperations; i++)
                {
                    var thread = new Thread(()=> 
                    {
                        Console.Write($"{Thread.CurrentThread.ManagedThreadId},");
                        Thread.Sleep(100);
                        countdown.Signal();
                    });
                    thread.Start();
                }
                countdown.Wait();
                Console.WriteLine();
            }
        }

        static void UseThreadPool(int numberOfoperations)
        {
            using (var countdown=new CountdownEvent(numberOfoperations))
            {
                Console.WriteLine("线程池工作调度");
                for (int i = 0; i < numberOfoperations; i++)
                {
                    ThreadPool.QueueUserWorkItem(_=> 
                    {
                        Console.Write($"{Thread.CurrentThread.ManagedThreadId},");
                        Thread.Sleep(100);
                        countdown.Signal();
                    });
                }
                countdown.Wait();
                Console.WriteLine();
            }
        }
    }
}
