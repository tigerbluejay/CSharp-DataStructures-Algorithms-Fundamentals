using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals._10_Singly_Linked_List
{
	public class SLLNode
	{
		public string Val { get; set; }
		public SLLNode Next { get; set; }

		public SLLNode(string val)
		{
			Val = val;
			Next = null;
		}
	}

	public partial class SinglyLinkedList
	{
		public SLLNode Head { get; private set; }
		public SLLNode Tail { get; private set; }
		public int Length { get; private set; }

		public SinglyLinkedList()
		{
			Head = null;
			Tail = null;
			Length = 0;
		}

	}

}
