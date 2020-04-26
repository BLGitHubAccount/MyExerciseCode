using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序算法
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,3,6,4,7,12,5,2,22,10 };
            //SelectSort(list);
            //BubbleSort(list);
            BubbleCocktailSort(list);
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }

        static void Swap(IList<int> datas, int a, int b)
        {
            datas[a] = datas[a] + datas[b];
            datas[b] = datas[a] - datas[b];
            datas[a] = datas[a] - datas[b];
        }
        /// <summary>
        /// 选择排序,时间复杂度O(n^2)
        /// </summary>
        /// <param name="datas"></param>
        static void SelectSort(IList<int> datas)
        {         
            for (int i = 0; i < datas.Count; i++)
            {
                int min = i;//假定索引0对应的为最小值
                for (int j = i+1; j < datas.Count; j++)                
                    if (datas[j] < datas[min])
                        min = j;                    
                if(min!=i)
                  Swap(datas, i, min);

            }
        }
        /// <summary>
        /// 冒泡排序 ，时间复杂度O(n^2)
        /// </summary>
        /// <param name="datas"></param>
        static void BubbleSort(IList<int> datas)
        {
            bool flag;//通过标识来减少排序时间，一轮排序下来flag为true则剩下的元素已经不需要再排序了
            for (int i = 0; i < datas.Count-1; i++)
            {
                flag = true;
                for (int j = datas.Count-1; j>=i+1; j--)
                {
                    if (datas[j] < datas[j-1])
                    {
                        Swap(datas,j,j-1);
                        flag = false;
                    }
                }
                if (flag) break;
            }
        }

        static void BubbleCocktailSort(IList<int> datas)
        {
            
            int m = 0, n = 0;
            for (int i = 0; i < datas.Count-1; i++)
            {
                
                if (i % 2 == 0)
                {
                  
                    for (int j = m; j < datas.Count-1-n; j++)
                    {
                        if (datas[j] > datas[j + 1])
                        {
                            Swap(datas,j,j+1);
                         
                        }
                      
                       
                    }
                  
                
                    n++;
                }
                else
                {
                 
                    for (int k = datas.Count-1-n; k >m; k--)
                    {
                        if (datas[k] < datas[k -1])
                        {
                            Swap(datas, k, k -1);
                         
                        }
                    

                    }
                  
                  
                    m++;
                }
            }
        }


        
    }
}
