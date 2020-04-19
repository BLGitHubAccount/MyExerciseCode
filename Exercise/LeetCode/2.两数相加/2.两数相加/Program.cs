using System;
using System.Collections.Generic;

namespace _2.两数相加
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data1 = new List<int>() { 2, 4, 3, 8 };
            List<int> data2 = new List<int>() { 5, 6, 4, 4 };

            var list = Fun2(data1, data2);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }

        //解法2
        static List<int> Fun2(List<int> list1, List<int> list2)
        {
            int carry_digt = 0;
            List<int> resList = new List<int>();
            int i = 0;
            while (list1.Count > i || list2.Count > i || carry_digt > 0)
            {
                int data1 = list1.Count > i ? list1[i] : 0;
                int data2 = list2.Count > i ? list2[i] : 0;
                int sum = data1 + data2 + carry_digt;
                int curValue = sum % 10;
                carry_digt = sum / 10;
                resList.Add(curValue);
                i++;
            }
            return resList;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

        }




    }
    public class ListNode
    {

        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

    }
}
