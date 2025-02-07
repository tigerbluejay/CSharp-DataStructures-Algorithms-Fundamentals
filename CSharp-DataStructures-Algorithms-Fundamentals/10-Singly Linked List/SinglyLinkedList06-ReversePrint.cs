using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals._10_Singly_Linked_List
{
	public partial class SinglyLinkedList
	{
		public void Print()
		{
			List<string> arr = new List<string>();
			SLLNode current = Head;
			while (current != null)
			{
				arr.Add(current.Val);
				current = current.Next;
			}
			Console.WriteLine("[" + string.Join(", ", arr) + "]");
		}

		public void Reverse()
		{
			SLLNode node = Head;
			Head = Tail;
			Tail = node;
			SLLNode next;
			SLLNode prev = null;

			for (int i = 0; i < Length; i++)
			{
				next = node.Next;
				node.Next = prev;
				prev = node;
				node = next;
			}
		}

	}
}
