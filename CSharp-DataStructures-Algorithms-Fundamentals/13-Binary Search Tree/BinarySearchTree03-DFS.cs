using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class BinarySearchTree
	{

		public List<int> DFSPreOrder()
		{
			List<int> data = new List<int>();
			void Traverse(BSTNode node)
			{
				if (node == null) return;
				data.Add(node.Value);
				Traverse(node.Left);
				Traverse(node.Right);
			}
			Traverse(Root);
			return data;
		}
		// if tree were:

		//          10
		//        6     15
		//      3   8      20

		// Depth First Pre Order: 10 6 3 8 15 20

		public List<int> DFSInOrder()
		{
			List<int> data = new List<int>();
			void Traverse(BSTNode node)
			{
				if (node == null) return;
				Traverse(node.Left);
				data.Add(node.Value);
				Traverse(node.Right);
			}
			Traverse(Root);
			return data;
		}

		// if tree were:

		//          10
		//        6     15
		//      3   8      20

		// Depth First In Order: 3 6 8 10 15 20

		public List<int> DFSPostOrder()
		{
			List<int> data = new List<int>();
			void Traverse(BSTNode node)
			{
				if (node == null) return;
				Traverse(node.Left);
				Traverse(node.Right);
				data.Add(node.Value);
			}
			Traverse(Root);
			return data;
		}

		// if tree were:

		//          10
		//        6     15
		//      3   8      20

		// Depth First Post Order: 3 8 6 20 15 10
	}
}
