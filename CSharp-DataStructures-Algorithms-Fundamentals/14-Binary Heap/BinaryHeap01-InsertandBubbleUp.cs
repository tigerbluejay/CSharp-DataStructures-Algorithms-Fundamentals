using CSharp_DataStructures_Algorithms_Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class MaxBinaryHeap
	{
		private List<int> values;

		public MaxBinaryHeap()
		{
			values = new List<int>();
		}

		public void Insert(int element)
		{
			values.Add(element);
			BubbleUp();
		}

		private void BubbleUp()
		{
			int idx = values.Count - 1;
			int element = values[idx];

			while (idx > 0)
			{
				int parentIdx = (idx - 1) / 2; // calculation to obtain parent element index
				int parent = values[parentIdx];

				if (element <= parent) break;

				// Swap parent and child
				values[parentIdx] = element;
				values[idx] = parent;
				idx = parentIdx;
			}
		}

		public void PrintHeap()
		{
			Console.WriteLine(string.Join(" ", values));
		}
	}
}
/*
static void Main()
{
	MaxBinaryHeap heap = new MaxBinaryHeap();

	(P denotes the parent of the last element inserted)
	heap.Insert(41); // 41P
	heap.Insert(39); // 41P (39)
	heap.Insert(33); // 41P (39 33)
	heap.Insert(18); // 41 39P 33 (18)
	heap.Insert(27); // 41 39P 33 (18 27)
	heap.Insert(12); // 41 39 33P 18 27 (12)
	heap.Insert(55); // 41 39 33P 18 27 (12 55) => swap parent for child
					 (because child 55 is greater than parent 33)
					 // 41 39 55P 18 27 (12 33) 
				     // 55P (39 41) 18 27 12 33 => swap parent for child
					 (because child 55 is greater than parent 41)

	heap.PrintHeap();
}
*/