using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{

	public class BSTNode
	{
		public int Value { get; set; }
		public BSTNode Left { get; set; }
		public BSTNode Right { get; set; }

		public BSTNode(int value)
		{
			Value = value;
			Left = null;
			Right = null;
		}
	}


	public partial class BinarySearchTree
	{
		public BSTNode Root { get; private set; }

		public BinarySearchTree()
		{
			Root = null;
		}

		public void Insert(int value)
		{
			BSTNode newNode = new BSTNode(value);
			if (Root == null)
			{
				Root = newNode;
				return;
			}

			BSTNode current = Root;
			while (true)
			{
				if (value < current.Value)
				{
					if (current.Left == null)
					{
						current.Left = newNode;
						return;
					}
					current = current.Left;
				}
				else
				{
					if (current.Right == null)
					{
						current.Right = newNode;
						return;
					}
					current = current.Right;
				}
			}
		}

		public BSTNode Find(int value)
		{
			BSTNode current = Root;
			while (current != null)
			{
				if (value == current.Value)
					return current;
				else if (value < current.Value)
					current = current.Left;
				else
					current = current.Right;
			}
			return null;
		}

		public bool Contains(int value)
		{
			return Find(value) != null;
		}

	}

}