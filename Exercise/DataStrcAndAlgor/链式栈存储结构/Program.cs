using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链式栈存储结构
{
    class Program
    {
        static void Main(string[] args)
        {
          var Instance=LinkStackTest<int>.Instance;
            Console.WriteLine("开始入栈..");
            for (int i = 0; i < 20; i++)
            {
                Instance.Push(i);
                Console.WriteLine(i); 
            }

            Console.WriteLine("开始出栈..");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Instance.Pop()); 
            }
            Console.ReadKey();
        }
    }
}
