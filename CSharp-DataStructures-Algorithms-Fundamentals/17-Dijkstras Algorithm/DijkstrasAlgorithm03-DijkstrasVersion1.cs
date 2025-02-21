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

	public partial class PriorityQueue<T> // this rest of this class is contained in DijkstrasAlgorithm02-PriorityQueue.cs
	{
		public int Count => values.Count;
	}

	public partial class WeightedGraph // the rest of this class is contained in DijkstrasAlgorithm01-WeightedGraph.cs
	{
		public List<string> Dijkstra(string start, string finish)
		{
			// Priority queue to store nodes with their distances (min-heap behavior)
			var nodes = new PriorityQueue<string>();

			// Dictionary to store the shortest known distance to each node
			var distances = new Dictionary<string, int>();

			// Dictionary to store the previous node in the shortest path
			var previous = new Dictionary<string, string?>();

			// List to store the final shortest path
			var path = new List<string>();

			// Initialize distances and priority queue
			foreach (var vertex in adjacencyList.Keys)
			{
				if (vertex == start)
				{
					distances[vertex] = 0;  // Distance to start node is 0
					nodes.Enqueue(vertex, 0);  // Start node has highest priority (lowest distance)
				}
				else
				{
					distances[vertex] = int.MaxValue;  // Set all other distances to "infinity"
					nodes.Enqueue(vertex, int.MaxValue);  // Add them to the priority queue
				}
				previous[vertex] = null;  // No known previous node yet
			}

			// Process the priority queue until all nodes are visited
			while (nodes.Count > 0)
			{
				var dequeuedNode = nodes.Dequeue(); // Get the node with the smallest distance
				var smallest = dequeuedNode.Item1; // Access the first element of the tuple (node name)

				// If we reached the target node, reconstruct the shortest path
				if (smallest == finish)
				{
					while (previous[smallest] != null)
					{
						path.Add(smallest);
						smallest = previous[smallest]; // Move to the previous node in the path
					}
					break;
				}

				// If the smallest node has an infinite distance, remaining nodes are unreachable
				if (distances[smallest] != int.MaxValue)
				{
					// Iterate through neighboring nodes
					foreach (var edge in adjacencyList[smallest])
					{
						int candidate = distances[smallest] + edge.Weight; // Calculate new distance
						if (candidate < distances[edge.Node]) // If shorter path found, update values
						{
							distances[edge.Node] = candidate; // Update shortest distance
							previous[edge.Node] = smallest; // Update previous node
							nodes.Enqueue(edge.Node, candidate); // Reinsert with updated priority
						}
					}
				}
			}

			// Reconstruct the shortest path in the correct order
			path.Add(start);
			path.Reverse();
			return path;
		}
	}
}

/*
Example Walkthrough
Suppose we call:
List<string> shortestPath = wgraph.Dijkstra("A", "F");

It calculates the shortest path from A to F.

Initialization:
A distance = 0, other nodes = ∞
Priority queue: [A(0), B(∞), C(∞), D(∞), E(∞), F(∞)]

Step 1: Process A
A → B (4), A → C (2)
B updated to 4, C updated to 2
Priority queue: [C(2), B(4), D(∞), E(∞), F(∞)]

Step 2: Process C
C → D (2 + 2 = 4)
D updated to 4
Priority queue: [D(4), B(4), E(∞), F(∞)]

Step 3: Process B
B → E (4 + 3 = 7)
E updated to 7
Priority queue: [D(4), E(7), F(∞)]

Step 4: Process D
D → E (4 + 3 = 7) (no change)
D → F (4 + 1 = 5)
F updated to 5
Priority queue: [F(5), E(7)]

Step 5: Process F
F is the target, stop.

Path Reconstruction:
F → D → C → A
Reverse: A → C → D → F
Final Output
["A", "C", "D", "F"]
This is the shortest path from A to F, with a total cost of 5.
*/