using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3._7使用计时器
{
    class Program
    {
        static void Main(string[] args)
        {

            Timer _timer = new Timer(TimerCallback,"baozi",100,1000);
            Thread.Sleep(TimeSpan.FromSeconds(6));
            _timer.Change(200,2000);
            Console.ReadKey();
        }

        static void TimerCallback(object state)
        {
            Console.WriteLine(System.DateTime.Now.ToString("HH:mm:ss")+"Hello!!"+state);
        }

    }
}
