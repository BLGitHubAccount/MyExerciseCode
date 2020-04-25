using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树_链式存储
{
    class BinaryTree<T>
    {
        TreeNode<T> head;//头指针
        private T[] datas;//用于构造二叉树的字符串

        public TreeNode<T> Head
        {
            get { return head; }
        }
        /// <summary>
        /// 创建二叉树
        /// </summary>
        /// <param name="vals"></param>
        public BinaryTree(T[] vals)
        {
            datas = vals;
            Add(head,0);
        }

        private void Add(TreeNode<T> parent, int index)
        {
            if (parent == null)
            {
                parent = new TreeNode<T>(datas[index]);
                head = parent;
            }
            int leftChiledIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            if (leftChiledIndex < datas.Length)
            {
                if (!datas[leftChiledIndex].Equals("#"))
                {
                    parent.LChild = new TreeNode<T>(datas[leftChiledIndex]);
                    Add(parent.LChild,leftChiledIndex);
                }
                else
                {
                    parent.LChild = null;
                }

            }
            if (rightChildIndex < datas.Length)
            {
                if (!datas[rightChildIndex].Equals("#"))
                {
                    parent.RChild = new TreeNode<T>(datas[rightChildIndex]);
                    Add(parent.RChild,rightChildIndex);
                }
                else
                {
                    parent.RChild = null;
                }
            }
            
        }
        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="node"></param>
        public void PreTraveral(TreeNode<T> node)
        {
            if (node != null)
            {
                Console.Write(node.Data+"");
                PreTraveral(node.LChild);
                PreTraveral(node.RChild);
            }
        }

        /// <summary>
        ///中序遍历
        /// </summary>
        /// <param name="node"></param>
        public void MiddleTraveral(TreeNode<T> node)
        {
            if (node != null)
            {
                
                MiddleTraveral(node.LChild);
                Console.Write(node.Data+"");
                MiddleTraveral(node.RChild);
            }
        }
        /// <summary>
        ///后序遍历
        /// </summary>
        /// <param name="node"></param>
        public void LastTraveral(TreeNode<T> node)
        {
            if (node != null)
            {

                LastTraveral(node.LChild);
                LastTraveral(node.RChild);
                Console.Write(node.Data + "");

            }
        }
        /// <summary>
        /// 层次遍历
        /// </summary>
        /// <param name="node"></param>
        public void LayerTraveral(TreeNode<T> node)
        {
            if (node == null) return;
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(node);
            while (queue.Count>0)
            {
                var temp = queue.Dequeue();
                Console.Write(temp.Data+"");
                if (temp.LChild != null) queue.Enqueue(temp.LChild);
                if (temp.RChild != null) queue.Enqueue(temp.RChild);
                
            }
        }

    }
}
