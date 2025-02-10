using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class DoublyLinkedList
    {

        public DLLNode Shift()
        {
            if (Length == 0) return null;
            DLLNode oldHead = Head;
            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = oldHead.Next;
                Head.Prev = null;
                oldHead.Next = null;
            }
            Length--;
            return oldHead;
        }

        public DoublyLinkedList Unshift(string val)
        {
            DLLNode newNode = new DLLNode(val);
            if (Length == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Head.Prev = newNode;
                newNode.Next = Head;
                Head = newNode;
            }
            Length++;
            return this;
        }
    }
}