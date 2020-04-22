using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表_链式存储结构
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datas = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("开始插入链表元素..");
            var Instance = LinkListTest.Instance;
            var head= Instance.CreateListHead<int>(datas);
            Instance.PrintList<int>(head);
            Console.WriteLine("获取索引为2的表元素值");
            Console.WriteLine(Instance.GetElem(head, 2));
            Console.WriteLine("向索引2后面插入元素0");
            Console.WriteLine(Instance.InsertElem(head, 2, 0)?"插入成功":"插入失败");
            Instance.PrintList<int>(head);
            Console.WriteLine("删除索引4的元素");
            Console.WriteLine("删除的索引为:"+Instance.DeleteElem(head, 4));
            Instance.PrintList<int>(head);
            Console.WriteLine("销毁链表"+ Instance.DeleteLinkList(head));


            Console.ReadKey();



        }
    }
}
