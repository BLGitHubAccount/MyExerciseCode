using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip_two_lists
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = MakeList(1,2,3,8,9,10);
            var b = MakeList(4,5,6,7);
            var head= Zip(a,b);
            PrintList(head);

            Console.ReadKey();
        }

        static void PrintList(Node<int> head)
        {
            while (head != null)
            {
                Console.Write(head.data+"->");
                head = head.next;
            }

        }

        static Node<int> Zip(Node<int> p, Node<int> q)
        {
            Node<int> head = new Node<int>(), zipper = head;
            while (true)
            {
                if (p == null)
                {
                    zipper.next = q;
                    break;
                }
                if (q == null)
                {
                    zipper.next = p;
                    break;
                }
                if (p.data < q.data)
                {
                    zipper.next = p;
                    p = p.next;               

                }
                else
                {
                    zipper.next = q;
                    q = q.next;
                    
                }
                zipper = zipper.next;
            }
            return head.next;
        }

        static Node<int> MakeList(params int[] datas)
        {
            Node<int> head = null;
            for (int i = datas.Length-1; i >=0; i--)
            {
                head = new Node<int> { data = datas[i], next = head };
            }
            return head;
        }
    }

    class Node<T>
    {
       public T data;
       public Node<T> next;
        public Node()
        {

        }
        public Node(T value)
        {
            this.data = value;
        }
    }
}
