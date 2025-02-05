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
		public SLLNode Get(int index)
		{
			if (index < 0 || index >= Length) return null;

			SLLNode current = Head;
			int counter = 0;

			while (counter != index)
			{
				current = current.Next;
				counter++;
			}

			return current;
		}

		public bool Set(int index, string val)
		{
			SLLNode foundNode = Get(index);
			if (foundNode != null)
			{
				foundNode.Val = val;
				return true;
			}
			return false;
		}
	}
}
