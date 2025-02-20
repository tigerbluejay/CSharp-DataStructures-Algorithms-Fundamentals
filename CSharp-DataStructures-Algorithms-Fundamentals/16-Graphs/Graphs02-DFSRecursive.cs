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
		public List<string> DepthFirstRecursive(string start)
		{
			var result = new List<string>();
			var visited = new HashSet<string>();

			void DFS(string vertex)
			{
				if (vertex == null) return;
				visited.Add(vertex);
				result.Add(vertex);

				foreach (var neighbor in adjacencyList[vertex])
				{
					if (!visited.Contains(neighbor))
					{
						DFS(neighbor);
					}
				}
			}

			DFS(start);
			return result;
		}
	}
}