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
		private Dictionary<string, List<string>> adjacencyList;

		public Graph()
		{
			adjacencyList = new Dictionary<string, List<string>>();
		}

		public void AddVertex(string vertex)
		{
			if (!adjacencyList.ContainsKey(vertex))
			{
				adjacencyList[vertex] = new List<string>();
			}
		}

		public void AddEdge(string v1, string v2)
		{
			if (adjacencyList.ContainsKey(v1) && adjacencyList.ContainsKey(v2))
			{
				adjacencyList[v1].Add(v2);
				adjacencyList[v2].Add(v1);
			}
		}

		public void RemoveEdge(string vertex1, string vertex2)
		{
			if (adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2))
			{
				adjacencyList[vertex1].Remove(vertex2);
				adjacencyList[vertex2].Remove(vertex1);
			}
		}

		public void RemoveVertex(string vertex)
		{
			if (adjacencyList.ContainsKey(vertex))
			{
				foreach (var adjacentVertex in new List<string>(adjacencyList[vertex]))
				{
					RemoveEdge(vertex, adjacentVertex);
				}
				adjacencyList.Remove(vertex);
			}
		}

		public void PrintGraph()
		{
			foreach (var vertex in adjacencyList)
			{
				Console.Write(vertex.Key + " -> ");
				Console.WriteLine(string.Join(", ", vertex.Value));
			}
		}
	}
}

