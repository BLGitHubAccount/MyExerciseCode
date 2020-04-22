using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序栈存储结构
{
   public class SequStack<T>
    {
		private static SequStack<T> _instance;

		public static SequStack<T> Instance
		{
			get 
			{
				if (_instance == null)
					return _instance = new SequStack<T>();
				else return _instance;
			}
			
		}

		public static readonly int MAXSIZE = 100;//栈的存储容量
		//public  int Count = 0;//栈中实际存放的元素数量
		private int _count;
		public int Count
		{
			get { return _count; }
			
		}

		public int Top=-1;//栈顶指针
		private T[] Datas = new T[MAXSIZE];
		/// <summary>
		/// 入栈
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name=""></param>
		/// <returns></returns>
		public bool Push(T value)
		{
			if (Top == MAXSIZE - 1)
			{
				Console.WriteLine("栈元素已达到上限");
				return false;
			}
			Top++;
			Datas[Top] = value;
			_count++;
			return true;
		}

		public T  Pop()
		{
			T value = default;
			if (Top == -1)
			{
				Console.WriteLine("栈内元素为空");
				return value;
			}
		    value = Datas[Top];
			Top--;
			_count--;
			return value;
		}

	}
}
