using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 顺序栈存储结构
{
    class Program
    {
        static void Main(string[] args)
        {
            var Instance = SequStack<int>.Instance;
            Console.WriteLine("开始向栈顶压入元素..");
            for (int i = 0; i < 100; i++)
            {
                Instance.Push(i);
                Console.WriteLine("进度："+i);
                Thread.Sleep(100);
            }

            Console.WriteLine("完成！");

            Console.WriteLine("尝试向已经元素已达上限的栈压入元素..");
            Instance.Push(0);
            Console.WriteLine("开始出栈...");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Instance.Pop()); 
            }
            Console.WriteLine("完毕！");
            Console.ReadKey();
        }
    }
}
