using System;
using static System.Console;
using System.Threading;
using System.Diagnostics;

     

namespace _1._7_线程优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Current Thread  priority :{Thread.CurrentThread.Priority} ");
            WriteLine($"runing on all cores available");
            RunThreads();
            WriteLine($"runing on single core");
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
            RunThreads();

            ReadKey();
        }

        static void RunThreads()
        {
            var sample = new ThreadSample();
            var threadOne = new Thread(sample.CountNumbers);
            threadOne.Name = "ThreadOne";
             
            var threadTwo = new Thread(sample.CountNumbers);
            threadTwo.Name = "ThreadTwo";

            threadOne.Priority = ThreadPriority.Highest;
            threadTwo.Priority = ThreadPriority.Lowest;
            threadOne.Start();
            threadTwo.Start();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            sample.Stop();
        }

    }
    public class ThreadSample
    {
        private bool _isStoped = false;
        public void Stop()
        {
            _isStoped = true;
        }
        public void CountNumbers()
        {
            long counter = 0;
            while (!_isStoped)
            {
                counter++;
            }
            WriteLine($"{Thread.CurrentThread.Name} with"+$"{Thread.CurrentThread.Priority,11} priority"+$"has a count={counter,13:N0}");
        }
    }
}
