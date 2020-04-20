using System;
using System.Threading;
namespace _3._2在线程池中调用委托
{
    class Program
    {
        static void Main(string[] args)
        {
            int threadid = 0;
            RunOnThreadPool poolDelegate = Test;
            var t = new Thread(()=>Test(out threadid));
            t.Start();
            t.Join();
            Console.WriteLine($"thread id:{threadid}");
            IAsyncResult r = poolDelegate.BeginInvoke(out threadid,Callback,"a delegate asynchronous call");
            r.AsyncWaitHandle.WaitOne();
            string result = poolDelegate.EndInvoke(out threadid,r);
            Console.WriteLine($"Thread pool worker thread id:{threadid}");
            Console.WriteLine(result);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            Console.ReadKey();
        }

        private delegate string RunOnThreadPool(out int threadid);

        private static void Callback(IAsyncResult ar)
        {
            Console.WriteLine("stating a callback..");
            Console.WriteLine($"state passed to a callback:{ar.AsyncState}");
            Console.WriteLine($"is thread pool thread:{Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"Thread pool worker thread id:{Thread.CurrentThread.ManagedThreadId}");
        }

        private static string Test(out int threadid)
        {
            Console.WriteLine("Staring..");
            Console.WriteLine($"is thread pool thread{Thread.CurrentThread.IsThreadPoolThread}");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            threadid = Thread.CurrentThread.ManagedThreadId;
            return $"Thread pool worker thread id was:{threadid}";
        }
    }
}
