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
		public bool Insert(int index, string val)
		{
			if (index < 0 || index > Length) return false;

			if (index == Length)
			{
				Push(val); // No need to change Push, since you didn't provide the original Push method, assume it returns void
				return true;
			}

			if (index == 0)
			{
				Unshift(val); // Since Unshift returns SinglyLinkedList, we can simply call it as is without needing a bool return
				return true;
			}

			SLLNode newNode = new SLLNode(val);
			SLLNode prev = Get(index - 1);
			SLLNode temp = prev.Next;
			prev.Next = newNode;
			newNode.Next = temp;

			Length++;
			return true;
		}

		public SLLNode Remove(int index)
		{
			if (index < 0 || index >= Length) return null;

			if (index == 0) return Shift();
			if (index == Length - 1) return Pop();

			SLLNode previousNode = Get(index - 1);
			SLLNode removed = previousNode.Next;
			previousNode.Next = removed.Next;

			Length--;
			return removed;
		}

	}
}
