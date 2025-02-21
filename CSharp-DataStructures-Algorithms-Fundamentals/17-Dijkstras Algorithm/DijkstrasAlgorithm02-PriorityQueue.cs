using CSharp_DataStructures_Algorithms_Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class DijkstrasAlgorithm
	{
	}

	public partial class PriorityQueue<T>
	{
		private List<(T Value, int Priority)> values;

		public PriorityQueue()
		{
			values = new List<(T, int)>();
		}

		public void Enqueue(T val, int priority)
		{
			values.Add((val, priority));
			Sort();
		}

		public (T Value, int Priority) Dequeue()
		{
			if (values.Count == 0)
				throw new InvalidOperationException("Queue is empty.");

			var item = values[0];
			values.RemoveAt(0);
			return item;
		}

		private void Sort()
		{
			values.Sort((a, b) => a.Priority.CompareTo(b.Priority));
		}
	}
}
