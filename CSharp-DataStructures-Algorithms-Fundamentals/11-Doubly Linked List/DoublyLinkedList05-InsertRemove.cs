using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class DoublyLinkedList
    {
        public bool Insert(int index, string val)
        {
            if (index < 0 || index > Length) return false;
            if (index == 0) return Unshift(val) != null;
            if (index == Length) return Push(val) != null;

            DLLNode newNode = new DLLNode(val);
            DLLNode beforeNode = Get(index - 1);
            DLLNode afterNode = beforeNode.Next;

            beforeNode.Next = newNode;
            newNode.Prev = beforeNode;
            newNode.Next = afterNode;
            afterNode.Prev = newNode;

            Length++;
            return true;
        }

        public DLLNode Remove(int index)
        {
            if (index < 0 || index >= Length) return null;
            if (index == 0) return Shift();
            if (index == Length - 1) return Pop();

            DLLNode removedNode = Get(index);
            DLLNode beforeNode = removedNode.Prev;
            DLLNode afterNode = removedNode.Next;

            beforeNode.Next = afterNode;
            afterNode.Prev = beforeNode;
            removedNode.Next = null;
            removedNode.Prev = null;

            Length--;
            return removedNode;
        }
    }
}