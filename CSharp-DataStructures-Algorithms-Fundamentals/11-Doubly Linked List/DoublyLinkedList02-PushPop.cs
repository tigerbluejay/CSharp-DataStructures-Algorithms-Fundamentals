using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class DoublyLinkedList
    {
        public DoublyLinkedList Push(string val)
        {
            DLLNode newNode = new DLLNode(val);
            if (Length == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
            }
            Length++;
            return this;
        }

        public DLLNode Pop()
        {
            if (Head == null) return null;
            DLLNode poppedNode = Tail;
            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail = poppedNode.Prev;
                Tail.Next = null;
                poppedNode.Prev = null;
            }
            Length--;
            return poppedNode;
        }

    }
}
