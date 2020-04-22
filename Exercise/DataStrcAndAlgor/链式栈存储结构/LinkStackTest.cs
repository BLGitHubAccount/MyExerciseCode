using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 链式栈存储结构
{
   public class LinkStackTest<T>
    {
		private static LinkStackTest<T> _instance;

		public static LinkStackTest<T> Instance
		{
			get 
			{ 
				if(_instance==null)
				  return _instance=new LinkStackTest<T>();
				return _instance;
			}
			
		}
		//栈顶指针
		private StackNode Top;

		private int _count;
		/// <summary>
		/// 栈中元素数量
		/// </summary>
		public int Count
		{
			get { return _count; }
			
		}

		public bool Push(T value)
		{
			if (Top == null)
			{
				Top = new StackNode();
			}
			StackNode newNode = new StackNode(value,Top);
			Top = newNode;//新元素赋值给栈顶指针
			_count++;
			return false;
		}

		public T Pop()
		{
			T value = default;
			if (Top == null)
				return value;
			value = Top.Data;
			Top = Top.next;
			return value;
		}

	   class StackNode
		{
			public T Data;
			public StackNode next;
			public StackNode()
			{

			}
			public StackNode(T value,StackNode nextNode)
			{
				this.Data = value;
				this.next = nextNode;
			}
		}

	}
}
