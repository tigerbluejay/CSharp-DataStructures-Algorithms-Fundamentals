using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class StacksandQueues
	{
		public class SNode
		{
			public int Value { get; set; }
			public SNode Next { get; set; }

			public SNode(int value)
			{
				Value = value;
				Next = null;
			}
		}

		public class CustomStack
		{
			private SNode first;
			private SNode last;
			private int size;

			public CustomStack()
			{
				first = null;
				last = null;
				size = 0;
			}

			public int Push(int val)
			{
				SNode newNode = new SNode(val);
				if (first == null)
				{
					first = newNode;
					last = newNode;
				}
				else
				{
					SNode temp = first;
					first = newNode;
					first.Next = temp;
				}
				return ++size;
			}

			public int? Pop()
			{
				if (first == null) return null;
				SNode temp = first;
				if (first == last)
				{
					last = null;
				}
				first = first.Next;
				size--;
				return temp.Value;
			}
		}
	}
}
