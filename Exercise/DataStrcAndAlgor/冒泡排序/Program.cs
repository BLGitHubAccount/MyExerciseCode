using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datas = { 1,2,38,6,10,9};
            int[] results = Short(datas);
            for (int i = 0; i < results.Length ; i++)
            {
                Console.Write(results[i]+"  ");
            }

            Console.ReadKey();
        }

       static int[] Short(int[] datas)
        {
            ///时间复杂度O(n^2)
            bool flag = true;
            for (int i = 0; i < datas.Length - 1; i++)
            {
                flag = true;
                for (int j = i; j < datas.Length - 1; j++)
                {
                    if (datas[j] > datas[j + 1])
                    { 
                        swap(datas, j, j + 1);
                        flag = false;
                    }
                }
                if (flag) break;

            }

            return datas;
                 
        }
              
            

       static void swap(int[] nums, int i, int j)
        {
            //中间变量法
            int tem = nums[i];
            nums[i] = nums[j];
            nums[j] = tem;

            //加减法方式，注意：避免两数相加，大小越界
            nums[i] += nums[j];
            nums[j] = nums[i] - nums[j];
            nums[i] = nums[i] - nums[j];
            

        }
    }
}
