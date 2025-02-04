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
		public SLLNode Shift()
		{
			if (Head == null) return null;

			SLLNode currentHead = Head;
			Head = currentHead.Next;
			Length--;

			if (Length == 0)
			{
				Tail = null;
			}
			return currentHead;
		}

		public SinglyLinkedList Unshift(string val)
		{
			var newNode = new SLLNode(val);
			if (Head == null)
			{
				Head = newNode;
				Tail = Head;
			}
			else
			{
				newNode.Next = Head;
				Head = newNode;
			}
			Length++;
			return this;
		}
	}
}

/*

Step				Head	Tail	Length	List Representation
After Pop()			A		C		3		A → B → C → null
After Shift()		B		C		2		B → C → null
After Unshift("A")	A		C		3		A → B → C → null

 */

