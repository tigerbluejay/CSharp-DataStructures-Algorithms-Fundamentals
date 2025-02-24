using System;
using System.Collections.Generic;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	// Class representing a weighted graph
	class WeightedGraph2
	{
		// Adjacency list representation of the graph
		private Dictionary<string, List<(string node, int weight)>> adjacencyList = new();

		// Adds a vertex (node) to the graph
		public void AddVertex(string vertex)
		{
			if (!adjacencyList.ContainsKey(vertex))
				adjacencyList[vertex] = new List<(string, int)>();
		}

		// Adds an edge between two vertices with a given weight (bidirectional graph)
		public void AddEdge(string vertex1, string vertex2, int weight)
		{
			adjacencyList[vertex1].Add((vertex2, weight));
			adjacencyList[vertex2].Add((vertex1, weight));
		}

		// Implements Dijkstra's algorithm to find the shortest path between two nodes
		public List<string> Dijkstra(string start, string finish)
		{
			var nodes = new PriorityQueue2(); // Priority queue to process nodes efficiently
			var distances = new Dictionary<string, int>(); // Stores shortest known distances
			var previous = new Dictionary<string, string?>(); // Stores path predecessors
			var path = new List<string>(); // Stores the final path
			string smallest = start; // The current node being processed

			// Initialization: Set distances to infinity and enqueue nodes
			foreach (var vertex in adjacencyList.Keys)
			{
				if (vertex == start)
				{
					distances[vertex] = 0;
					nodes.Enqueue(vertex, 0);
				}
				else
				{
					distances[vertex] = int.MaxValue;
					nodes.Enqueue(vertex, int.MaxValue);
				}
				previous[vertex] = null;
			}

			// Main loop: Process nodes in order of shortest known distance
			while (nodes.Count > 0)
			{
				smallest = nodes.Dequeue(); // Get node with smallest known distance

				// If we reach the destination, reconstruct the shortest path
				if (smallest == finish)
				{
					while (previous[smallest] != null)
					{
						path.Add(smallest);
						smallest = previous[smallest]!;
					}
					break;
				}

				// If the smallest node has an infinite distance, stop (remaining nodes are unreachable)
				if (distances[smallest] != int.MaxValue)
				{
					// Iterate through neighboring nodes
					foreach (var (nextNode, weight) in adjacencyList[smallest])
					{
						int candidate = distances[smallest] + weight; // Calculate new possible distance
						if (candidate < distances[nextNode])
						{
							distances[nextNode] = candidate; // Update distance
							previous[nextNode] = smallest; // Update previous node
							nodes.Enqueue(nextNode, candidate); // Re-enqueue with updated priority
						}
					}
				}
			}

			path.Add(smallest);
			path.Reverse(); // Reverse path to get correct order from start to finish
			return path;
		}
	}

	// Priority queue (min-heap) implementation for efficient Dijkstra's algorithm
	class PriorityQueue2
	{
		private List<DA2Node> values = new();
		public int Count => values.Count;

		// Enqueue a node with a priority value
		public void Enqueue(string val, int priority)
		{
			values.Add(new DA2Node(val, priority));
			BubbleUp(); // Maintain heap property
		}

		// Moves the newly added element to its correct position in the heap
		private void BubbleUp()
		{
			int idx = values.Count - 1;
			DA2Node element = values[idx];
			while (idx > 0)
			{
				int parentIdx = (idx - 1) / 2;
				DA2Node parent = values[parentIdx];
				if (element.Priority >= parent.Priority) break;
				values[parentIdx] = element;
				values[idx] = parent;
				idx = parentIdx;
			}
		}

		// Dequeues the node with the highest priority (smallest value)
		public string Dequeue()
		{
			if (values.Count == 0) throw new InvalidOperationException("Queue is empty");
			DA2Node min = values[0]; // Root element (smallest priority)
			DA2Node end = values[^1];
			values.RemoveAt(values.Count - 1);
			if (values.Count > 0)
			{
				values[0] = end;
				SinkDown(); // Maintain heap property
			}
			return min.Val;
		}

		// Moves the root element down to its correct position in the heap
		private void SinkDown()
		{
			int idx = 0;
			int length = values.Count;
			DA2Node element = values[0];

			while (true)
			{
				int leftChildIdx = 2 * idx + 1;
				int rightChildIdx = 2 * idx + 2;
				int swapIdx = -1;

				if (leftChildIdx < length && values[leftChildIdx].Priority < element.Priority)
					swapIdx = leftChildIdx;

				if (rightChildIdx < length && values[rightChildIdx].Priority < (swapIdx == -1 ? element.Priority : values[leftChildIdx].Priority))
					swapIdx = rightChildIdx;

				if (swapIdx == -1) break;
				values[idx] = values[swapIdx];
				values[swapIdx] = element;
				idx = swapIdx;
			}
		}
	}

	// Class representing a node in the priority queue
	class DA2Node
	{
		public string Val { get; } // Node value
		public int Priority { get; } // Priority value (distance in Dijkstra)

		public DA2Node(string val, int priority)
		{
			Val = val;
			Priority = priority;
		}
	}
}
