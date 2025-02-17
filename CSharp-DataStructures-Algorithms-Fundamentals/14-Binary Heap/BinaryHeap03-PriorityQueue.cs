using System;
using System.Collections.Generic;

public class PriorityQueue
{
	private List<PQNode> values;

	public PriorityQueue()
	{
		values = new List<PQNode>();
	}

	// Enqueue a new node with a value and a priority
	public void Enqueue(string val, int priority)
	{
		PQNode newNode = new PQNode(val, priority);
		values.Add(newNode);
		BubbleUp();
	}

	// Bubble up the newly added node to maintain the heap order
	private void BubbleUp()
	{
		int idx = values.Count - 1;
		PQNode element = values[idx];

		// Continue moving up the heap until the parent's priority is less
		while (idx > 0)
		{
			int parentIdx = (idx - 1) / 2;
			PQNode parent = values[parentIdx];

			// If the parent's priority is less than or equal to the current element's priority, break
			if (element.Priority >= parent.Priority)
				break;

			// Swap the element with its parent
			values[parentIdx] = element;
			values[idx] = parent;
			idx = parentIdx;
		}
	}

	// Dequeue removes and returns the node with the highest priority (root of the heap)
	public PQNode Dequeue()
	{
		PQNode min = values[0]; // The root node (highest priority)
		PQNode end = values[values.Count - 1]; // Get the last node

		values.RemoveAt(values.Count - 1); // Remove the last node

		if (values.Count > 0)
		{
			// Replace the root with the last element and sink it down
			values[0] = end;
			SinkDown();
		}

		return min;
	}

	// Sink down the root element to maintain heap order after removal
	private void SinkDown()
	{
		int idx = 0;
		int length = values.Count;
		PQNode element = values[0];

		while (true)
		{
			int leftChildIdx = 2 * idx + 1;
			int rightChildIdx = 2 * idx + 2;
			PQNode leftChild = null, rightChild = null;
			int? swap = null;

			// Check if the left child exists and has a higher priority
			if (leftChildIdx < length)
			{
				leftChild = values[leftChildIdx];
				if (leftChild.Priority < element.Priority)
				{
					swap = leftChildIdx;
				}
			}

			// Check if the right child exists and has a higher priority than the left child or element
			if (rightChildIdx < length)
			{
				rightChild = values[rightChildIdx];
				if ((swap == null && rightChild.Priority < element.Priority) ||
					(swap != null && rightChild.Priority < leftChild.Priority))
				{
					swap = rightChildIdx;
				}
			}

			// If no swaps are needed, break out of the loop
			if (swap == null)
				break;

			// Swap the element with the chosen child
			values[idx] = values[swap.Value];
			values[swap.Value] = element;
			idx = swap.Value;
		}
	}
}

public class PQNode
{
	public string Val { get; set; }
	public int Priority { get; set; }

	public PQNode(string val, int priority)
	{
		Val = val;
		Priority = priority;
	}
}

/*
class Program
{
	static void Main()
	{
		PriorityQueue ER = new PriorityQueue();

		// Order of calls and expected behavior:

		ER.Enqueue("common cold", 5);
		ER.Enqueue("gunshot wound", 1);
		// Gunshot wound (1) is compared to common cold (5) and swapped to root.

		ER.Enqueue("high fever", 4);
		// High fever (4) is placed as the right child of common cold (5).

		ER.Enqueue("broken arm", 2);
		// Broken arm (2) is compared to common cold (5) and swapped.
		// Then compared to gunshot wound (1) and not swapped.

		ER.Enqueue("glass in foot", 3);
		// Glass in foot (3) is placed as the child of broken arm (2) without needing to swap.

		ER.Dequeue();
		// Gunshot wound (1) is removed and the heap is rearranged.
		// Broken arm (2) becomes the new root, and the heap is adjusted.
	}
}
*/