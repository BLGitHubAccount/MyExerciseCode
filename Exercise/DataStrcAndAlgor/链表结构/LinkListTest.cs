using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 线性表_链式存储结构
{
  public  class LinkListTest
    {
		/// <summary>
		/// 单例模式
		/// </summary>
		private static LinkListTest _instance;

		public static LinkListTest Instance
		{
			get
			{
				if (_instance == null) return _instance = new LinkListTest();
				else return _instance;
			}
			
		}
		public int Count = 0;

		public class Node<T>
		{
		  public T Data;//数据域
		  public  Node<T> next;//指针域
			public Node()
			{

			}
			public Node(T value)
			{
				this.Data = value;
			}

		}
		/// <summary>
		/// 头插法创建线性链表
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="datas"></param>
		/// <returns></returns>
		public Node<T> CreateListHead<T>(T[] datas)
		{
			Node<T> head = new Node<T>();
			head.next = null;
			Count = 0;
			for (int i = 0; i < datas.Length; i++)
			{
				Node<T> newNode = new Node<T>(datas[i]);			
				newNode.next = head.next;
				head.next = newNode;
				Count++;
			}
			return head;
		}
		/// <summary>
		/// 尾插法创建线性链表
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="datas"></param>
		/// <returns></returns>
		public Node<T> CreateListTail<T>(T[] datas)
		{
			Node<T> head = new Node<T>();
			Node<T> tail = new Node<T>();
			head.next = tail;
			Count = 0;
			for (int i = 0; i < datas.Length; i++)
			{
				Node<T> newNode = new Node<T>(datas[i]);
				tail.next = newNode;
				tail = newNode;
				Count++;
			}
			tail.next = null;//尾节点的指针域为空
			return head;
		}

		public void PrintList<T>(Node<T> head)
		{
			if (head.next == null) Console.WriteLine("当前链表数据为空！");
			Node<T> temNode = head.next;
			while (temNode!=null)
			{
				Console.Write(temNode.Data);
				temNode = temNode.next;
			}
			
		}
		/// <summary>
		/// 查询指定位置的节点
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="head"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		public T GetElem<T>(Node<T> head, int i)
		{
			T value;
			Node<T> temNode = head.next;
			int j = 0;
			while (temNode != null && j < i)
			{
				temNode = temNode.next;
				j++;
			}
			if (temNode == null || j > i)
			{
				return default(T);
			}
			value = temNode.Data;
			return value;
		}
		/// <summary>
		/// 向指定位置插入节点
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="head"></param>
		/// <param name="i"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public bool InsertElem<T>(Node<T> head, int i, T value)
		{
			Node<T> temNode = head.next;
			int  j = 0;
			while (temNode!=null&&j<i)
			{
				temNode = temNode.next;
				j++;
			}
			if (temNode == null || j > i)
			{
				return false;
			}
			Node<T> newNode = new Node<T>(value);
			newNode.next = temNode.next;
			temNode.next = newNode;
			Count++;
			return true;
		}
		/// <summary>
		/// 删除链表的第i个节点，并返回删除的节点值
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="head"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		public T DeleteElem<T>(Node<T> head, int i)
		{
			int j = 1;
			Node<T> temNode = head.next;
			Node<T> temNodeNextNode;
			while (temNode != null && j < i)
			{
				temNode = temNode.next;
				j++;
			}
			if (temNode == null || j > i)			
				  return default(T);

			temNodeNextNode = temNode.next;
			temNode.next = temNodeNextNode.next;
			T value = temNodeNextNode.Data;
			Count--;
			return value;

		}
		/// <summary>
		/// 销毁链表
		/// </summary>
		/// <param name="head"></param>
		/// <returns></returns>
		public bool DeleteLinkList<T>(Node<T> head)
		{
			bool flag = false;
			if (head != null)
			{
				head.next = null;
				flag = true;
			}
			Count = 0;
			return flag;
		}


	}
}
