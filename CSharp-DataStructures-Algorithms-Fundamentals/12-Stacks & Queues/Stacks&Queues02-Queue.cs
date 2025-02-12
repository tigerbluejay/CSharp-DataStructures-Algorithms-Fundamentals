using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class StacksandQueues
	{
		public class QNode
		{
			public int Value { get; set; }
			public QNode Next { get; set; }

			public QNode(int value)
			{
				Value = value;
				Next = null;
			}
		}

		public class CustomQueue
		{
			private QNode first;
			private QNode last;
			private int size;

			public CustomQueue()
			{
				first = null;
				last = null;
				size = 0;
			}

			public int Enqueue(int val)
			{
				QNode newNode = new QNode(val);
				if (first == null)
				{
					first = newNode;
					last = newNode;
				}
				else
				{
					last.Next = newNode;
					last = newNode;
				}
				return ++size;
			}

			public int? Dequeue()
			{
				if (first == null) return null;
				QNode temp = first;
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