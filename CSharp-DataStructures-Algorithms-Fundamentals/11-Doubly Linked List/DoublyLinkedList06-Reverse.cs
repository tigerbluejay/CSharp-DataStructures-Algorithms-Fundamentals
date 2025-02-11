using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class DoublyLinkedList
    {
        public DoublyLinkedList Reverse()
        {
            DLLNode node = Head;
            Head = Tail;
            Tail = node;
            DLLNode next;
            DLLNode prev = null;

            for (int i = 0; i < Length; i++)
            {
                next = node.Next;
                node.Next = prev;
                node.Prev = next;

                prev = node;
                node = next;
            }
            return this;
        }
    }
}