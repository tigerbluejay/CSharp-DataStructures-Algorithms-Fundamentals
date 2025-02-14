using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class BinarySearchTree
	{
		public bool IsBalanced()
		{
			return CheckHeight(Root) != -1;
		}

		private int CheckHeight(BSTNode node)
		{
			if (node == null)
			{
				return 0; // Height of an empty tree is 0
			}

			// Recursively calculate the height of the left and right subtrees
			int leftHeight = CheckHeight(node.Left);
			int rightHeight = CheckHeight(node.Right);

			// If any subtree is unbalanced, return -1 to indicate unbalance
			if (leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1)
			{
				return -1;
			}

			// Return the height of the current node
			return Math.Max(leftHeight, rightHeight) + 1;
		}
	}
}

// for this tree

//            1
//        2      3
//     4

/*
CheckHeight(1)
├── CheckHeight(2)
│   ├── CheckHeight(4)
│   │   ├── CheckHeight(null) → 0
│   │   ├── CheckHeight(null) → 0
│   │   └── Max(0, 0) + 1 → 1
│   ├── CheckHeight(null) → 0
│   └── Max(1, 0) + 1 → 2
├── CheckHeight(3)
│   ├── CheckHeight(null) → 0
│   ├── CheckHeight(null) → 0
│   └── Max(0, 0) + 1 → 1
└── Max(2, 1) + 1 → 3
*/