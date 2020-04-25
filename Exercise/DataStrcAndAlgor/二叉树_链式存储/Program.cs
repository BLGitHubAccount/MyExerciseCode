using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树_链式存储
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] datas = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

            BinaryTree<char> tree = new BinaryTree<char>(datas);
            Console.Write("先序遍历:");
            tree.PreTraveral(tree.Head);
            Console.WriteLine();
            Console.Write("中序遍历:");
            tree.MiddleTraveral(tree.Head);
            Console.WriteLine();
            Console.Write("后续遍历:");
            tree.LastTraveral(tree.Head);
            Console.WriteLine();
            Console.Write("层次遍历:");
            tree.LastTraveral(tree.Head);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
