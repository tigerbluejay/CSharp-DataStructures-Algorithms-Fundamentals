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

		public SinglyLinkedList Push(string val)
		{
			var newNode = new SLLNode(val);
			// if no head, set the head to be the new node, and the tail to be also the head
			if (Head == null)
			{
				Head = newNode;
				Tail = Head;
			}
			// if there's a head
			else {
				Tail.Next = newNode; // Link the last node to the new node
				Tail = newNode;		 // Move the tail pointer to the new node
			}
			Length++;
			return this;
		}

		public SLLNode Pop()
		{
			if (Head == null) return null;

			SLLNode current = Head;
			SLLNode newTail = current;
			while (current.Next != null) // if there's a next node already
			{
				// while there is current.Next assigned
				newTail = current;	// set the current to be the new Tail
				current = current.Next; // and the next to be the current to be returned later
			}

			Tail = newTail;
			Tail.Next = null;
			Length--;

			if (Length == 0)
			{
				Head = null;
				Tail = null;
			}
			return current;
		}
	}
}

/*
Step	        Head	Tail	Length	List Representation
Initial	        null	null	0	    null
Push("A")	    A	    A	    1	    A → null
Push("B")	    A	    B	    2	    A → B → null
Push("C")	    A	    C	    3	    A → B → C → null
Push("D")	    A	    D   	4	    A → B → C → D → null
Pop()	        A	    C	    3	    A → B → C → null
*/
