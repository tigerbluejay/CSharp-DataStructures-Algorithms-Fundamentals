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

	public partial class WeightedGraph
	{
		private Dictionary<string, List<WGEdge>> adjacencyList;

		public WeightedGraph()
		{
			adjacencyList = new Dictionary<string, List<WGEdge>>();
		}

		public void AddVertex(string vertex)
		{
			if (!adjacencyList.ContainsKey(vertex))
			{
				adjacencyList[vertex] = new List<WGEdge>();
			}
		}

		public void AddEdge(string vertex1, string vertex2, int weight)
		{
			if (adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2))
			{
				adjacencyList[vertex1].Add(new WGEdge(vertex2, weight));
				adjacencyList[vertex2].Add(new WGEdge(vertex1, weight));
			}
		}
	}

	class WGEdge
	{
		public string Node { get; }
		public int Weight { get; }

		public WGEdge(string node, int weight)
		{
			Node = node;
			Weight = weight;
		}
	}

}
