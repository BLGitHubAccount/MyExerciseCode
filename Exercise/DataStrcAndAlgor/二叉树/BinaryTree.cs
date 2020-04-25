using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树
{
    //如果存储结点为空，用-1进行表示
    class BinaryTree<T>
    {
       private T[] datas;
        private int count = 0;//元素个数 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacity">二叉树的容量</param>
        public BinaryTree(int capacity)
        {
            datas = new T[capacity];
        }

        public bool AddItem(T item)
        {
            if (count >= datas.Length)
                return false;
            datas[count] = item;
            count++;
            return true;
        }
        public void FirstTraversal()
        {
            FirstTraversal(0);
        }
        private void FirstTraversal(int index)
        {
            if (index >= count || datas[index].Equals(-1))
                return;
            int number = index + 1;
            int leftnumber = 2 * number;
            int rightnumber = 2 * number + 1;
            Console.Write(datas[index]+"");
            FirstTraversal(leftnumber-1);
            FirstTraversal(rightnumber-1);

        }

        public void MiddleTraversal()
        {
            MiddleTraversal(0);
        }
        private void MiddleTraversal(int index)
        {
            if (index >= count || datas[index].Equals(-1))
                return;
            int number = index + 1;
            int leftnumber = 2 * number;
            int rightnumber = 2 * number + 1;          
            FirstTraversal(leftnumber - 1);
            Console.Write(datas[index] + "");
            FirstTraversal(rightnumber - 1);
        }

        public void LastTraversal()
        {
            LastTraversal(0);
        }
        private void LastTraversal(int index)
        {
            if (index >= count || datas[index].Equals(-1))
                return;
            int number = index + 1;
            int leftnumber = 2 * number;
            int rightnumber = 2 * number + 1;
            FirstTraversal(leftnumber - 1);           
            FirstTraversal(rightnumber - 1);
            Console.Write(datas[index] + "");
        }

        public void LayerTraversal()
        {
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i].Equals(-1))
                    continue;
                Console.Write(datas[i]+"");                
                               
            }
        }
    }
}
