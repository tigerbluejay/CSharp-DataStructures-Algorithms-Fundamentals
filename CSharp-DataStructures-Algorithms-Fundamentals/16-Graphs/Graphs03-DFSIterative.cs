using CSharp_DataStructures_Algorithms_Fundamentals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class Graph
	{
		public List<string> DepthFirstIterative(string start)
		{
			var stack = new Stack<string>();
			var result = new List<string>();
			var visited = new HashSet<string>();

			stack.Push(start);
			visited.Add(start);

			while (stack.Count > 0)
			{
				var currentVertex = stack.Pop();
				result.Add(currentVertex);

				foreach (var neighbor in adjacencyList[currentVertex])
				{
					if (!visited.Contains(neighbor))
					{
						visited.Add(neighbor);
						stack.Push(neighbor);
					}
				}
			}
			return result;
		}
	}
}