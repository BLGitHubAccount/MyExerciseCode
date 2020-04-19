using System;
using System.Collections.Generic;

namespace _2.两数相加
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data1 = new List<int>() { 2, 4, 3 ,8};
            List<int> data2 = new List<int>() { 5, 6, 4 ,4};

            var list= Fun(data1,data2);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
        //解法1
        static List<int>  Fun(List<int> ary1, List<int> ary2)
        {
            int data1 = 0;
            for (int i = 0; i < ary1.Count; i++)
            {
                data1 += ary1[i] * (int)Math.Pow(10,i);
            }
            int data2 = 0;
            for (int i = 0; i < ary2.Count; i++)
            {
                data2 += ary2[i] * (int)Math.Pow(10, i);
            }
            List<int> res = new List<int>();
            string target = (data1 + data2).ToString();
            for (int i = target.Length-1; i >=0; i--)
            {
                res.Add(int.Parse(target[i].ToString()));
            }
            return res;
        }
        //解法2
        static List<int> Fun2(List<int> list1, List<int> list2)
        {
            int carry_digt = 0;
            List<int> resList = new List<int>();
            int i = 0;
            while (list1.Count>i || list2.Count>i || carry_digt>0)
            {
                int data1 = list1.Count > i ? list1[i]:0;
                int data2 = list2.Count > i ? list2[i]:0;
                int sum = data1 + data2 + carry_digt;
                int curValue = sum % 10;
                carry_digt = sum / 10;
                resList.Add(curValue);
                i++;
            }
            return resList;
        }
    }
}
