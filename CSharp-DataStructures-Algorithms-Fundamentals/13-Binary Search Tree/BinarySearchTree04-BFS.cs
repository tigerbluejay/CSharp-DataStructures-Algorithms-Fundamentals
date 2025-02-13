using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class BinarySearchTree
	{
		public List<int> BFS()
		{
			List<int> data = new List<int>();
			Queue<BSTNode> queue = new Queue<BSTNode>();
			if (Root != null) queue.Enqueue(Root);

			while (queue.Count > 0)
			{
				BSTNode node = queue.Dequeue();
				data.Add(node.Value);
				if (node.Left != null) queue.Enqueue(node.Left);
				if (node.Right != null) queue.Enqueue(node.Right);
			}
			return data;
		}
		//          10
		//        6     15
		//      3   8      20

		// Breadth First: 10 6 15 3 8 20

		// queue:  10
		// queue:  6 15
		// queue:  15 3 8
		// queue:  3 8 20
		// queue:  8 20
		// queue:  20
	}
}
