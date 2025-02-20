using CSharp_DataStructures_Algorithms_Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class Graph
	{
		public List<string> BreadthFirst(string start)
		{
			var queue = new Queue<string>();
			var result = new List<string>();
			var visited = new HashSet<string>();

			queue.Enqueue(start);
			visited.Add(start);

			while (queue.Count > 0)
			{
				var currentVertex = queue.Dequeue();
				result.Add(currentVertex);

				foreach (var neighbor in adjacencyList[currentVertex])
				{
					if (!visited.Contains(neighbor))
					{
						visited.Add(neighbor);
						queue.Enqueue(neighbor);
					}
				}
			}
			return result;
		}

	}
}