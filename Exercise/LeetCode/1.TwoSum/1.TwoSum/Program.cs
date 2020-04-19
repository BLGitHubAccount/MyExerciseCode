﻿using System;
using System.Collections.Generic;

namespace _1.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,7,11,15 };
            
           int[] res= GetTwoSumIndex(nums,9);
            if(res.Length==2)
            Console.WriteLine($"[{res[0]},{res[1]}]");
            Console.ReadKey();
        }

        static int[] GetTwoSumIndex(int[] nums, int target)
        {
            
            int[] res = new int[2];
            if (nums == null || nums.Length == 0) return res;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int tag = target - nums[i];
                if (dic.ContainsKey(tag))
                {
                    res[0] = dic[tag];
                    res[1] = i;
                    return res;
                }
                else { dic.Add(nums[i], i); }
            }
            return res;
        }
    }
}
