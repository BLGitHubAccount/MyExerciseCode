using System;
using System.Threading;
namespace _2._10使用SpinWait类
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread(UserModeWait);
            var t2 = new Thread(HybridSpinWait);

            Console.WriteLine("runing user mode waiting");
            t1.Start();
            Thread.Sleep(20);
            _isCompleted = true;
            Thread.Sleep(TimeSpan.FromSeconds(1));
            _isCompleted = false;
            Console.WriteLine("runing hybrid spinwait construct waiting");
            t2.Start();
            Thread.Sleep(5);
            _isCompleted = true;

            Console.ReadKey();
        }
        static volatile bool _isCompleted = false;

        static void UserModeWait()
        {
            while (!_isCompleted)
            {
                Console.WriteLine(".");

            }
            Console.WriteLine();
            Console.WriteLine("Waiting is complete");
        }
        static void HybridSpinWait()
        {
            var w = new SpinWait();
            while (!_isCompleted)
            {
                w.SpinOnce();
                Console.WriteLine(w.NextSpinWillYield);
            }
            Console.WriteLine("waiting is completed");
        }
    }
}
