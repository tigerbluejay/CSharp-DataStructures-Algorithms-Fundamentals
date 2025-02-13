using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class BinarySearchTree
	{
		public void Remove(int value)
		{
			Root = RemoveNode(Root, value);
		}

		public BSTNode RemoveNode(BSTNode node, int value)
		{
			if (node == null) return null;

			if (value < node.Value)
			{
				node.Left = RemoveNode(node.Left, value);
			}
			else if (value > node.Value)
			{
				node.Right = RemoveNode(node.Right, value);
			}
			else
			{
				// Node found
				if (node.Left == null && node.Right == null)
				{
					return null;
				}
				else if (node.Left == null)
				{
					return node.Right;
				}
				else if (node.Right == null)
				{
					return node.Left;
				}
				else
				{
					// Find inorder successor
					BSTNode successor = node.Right;
					while (successor.Left != null)
					{
						successor = successor.Left;
					}
					node.Value = successor.Value;
					node.Right = RemoveNode(node.Right, successor.Value);
				}
			}
			return node;
		}
	}
}
