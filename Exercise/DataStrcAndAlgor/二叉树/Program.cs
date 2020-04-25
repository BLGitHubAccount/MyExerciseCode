using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] datas = new char[] {'A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
            BinaryTree<char> tree = new BinaryTree<char>(10);
            for (int i = 0; i < datas.Length; i++)
            {
                tree.AddItem(datas[i]);
            }

            Console.Write("先序遍历:");
            tree.FirstTraversal();
            Console.WriteLine();
            Console.Write("中序遍历:");
            tree.MiddleTraversal();
            Console.WriteLine();
            Console.Write("后续遍历:");
            tree.LastTraversal();
            Console.WriteLine();
            Console.Write("层次遍历:");
            tree.LayerTraversal();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

