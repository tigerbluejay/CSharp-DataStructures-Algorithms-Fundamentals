using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals._10_Singly_Linked_List
{
	public partial class SinglyLinkedList
	{
		public void Rotate(int k)
		{
			if (Head == null || Length <= 1) return; // Handle empty list or single element

			k = k % Length; // Normalize k within the bounds of the list length
			if (k < 0) k += Length; // Convert negative k to equivalent positive rotation

			SLLNode current = Head;
			SLLNode prev = null;
			int count = 1;

			// Find the k-th node from the beginning
			while (current != null && count < k)
			{
				prev = current;
				current = current.Next;
				count++;
			}

			if (current == null) return; // If k is equal to length, no rotation needed

			Tail.Next = Head; // Connect the tail to the head to form a circular list
			Head = current.Next; // Set the new head to the next node after k
			current.Next = null; // Break the circular link to finalize the rotation
			Tail = current; // Update the tail to the k-th node
		}
	}
}
