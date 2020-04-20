using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _3._3向线程池中放入异步操作
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 1;
            const int y = 2;
            const string lambdaState = "lambda state 2";

            ThreadPool.QueueUserWorkItem(AsyncOperation);
            Thread.Sleep(TimeSpan.FromSeconds(6));
            ThreadPool.QueueUserWorkItem(AsyncOperation,"async state");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            ThreadPool.QueueUserWorkItem(state =>
            {
                Console.WriteLine($"Operation state:{state}");
                Console.WriteLine($"worker thread id:{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(TimeSpan.FromSeconds(2));
            },"lambda state");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            ThreadPool.QueueUserWorkItem(_t =>
            {
                Console.WriteLine($"Operation state:{x+y},{lambdaState}");
                Console.WriteLine($"worker thread id:{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }, "lambda state");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.ReadKey();
        }
        private static void AsyncOperation(object state)
        {
            Console.WriteLine($"Operation state:{state??"(null)"}");
            Console.WriteLine($"worker thread id:{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
