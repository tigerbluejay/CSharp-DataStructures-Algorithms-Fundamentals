using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class BinarySearchTree
	{
		public BSTNode FindLargestNode(BSTNode node)
		{
			if (node == null)
			{
				return null;
			}

			BSTNode current = node;
			while (current.Right != null)
			{
				current = current.Right;
			}
			return current;
		}

		public int? FindSecondLargest()
		{
			if (Root == null || (Root.Left == null && Root.Right == null))
			{
				return null; // Tree is empty or has only one node
			}

			BSTNode secondLargest = null;
			BSTNode current = Root;

			while (current != null)
			{
				if (current.Right == null && current.Left != null)
				{
					// If current node is the largest and has a left subtree
					// Then the second largest is the largest node in its left subtree
					secondLargest = FindLargestNode(current.Left);
					break;
				}

				if (current.Right != null && current.Right.Left == null && current.Right.Right == null)
				{
					// If current node's right child is the largest and it has no left child
					// Then current node is the second largest
					secondLargest = current;
					break;
				}

				current = current.Right;
			}

			return secondLargest?.Value;
		}
	}
}
