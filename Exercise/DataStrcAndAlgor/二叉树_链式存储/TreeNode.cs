using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树_链式存储
{
    class TreeNode<T>
    {
		private T data;

		public T Data
		{
			get { return data; }
			set { data = value; }
		}

		private TreeNode<T> lChild;

		public TreeNode<T> LChild
		{
			get { return lChild; }
			set { lChild = value; }
		}

		private TreeNode<T> rChild;

		public TreeNode<T> RChild
		{
			get { return rChild; }
			set { rChild = value; }
		}

		public TreeNode()
		{
			data = default;
			lChild = null;
			rChild = null;
		}

		public TreeNode(T value)
		{
			data = value;
			lChild = null;
			rChild = null;
		}


	}
}
