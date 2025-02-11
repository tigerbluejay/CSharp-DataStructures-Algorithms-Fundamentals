using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class DoublyLinkedList
    {
        public DLLNode Get(int index)
        {
            if (index < 0 || index >= Length) return null;
            DLLNode current;
            if (index <= Length / 2)
            {
                current = Head;
                for (int count = 0; count != index; count++)
                {
                    current = current.Next;
                }
            }
            else
            {
                current = Tail;
                for (int count = Length - 1; count != index; count--)
                {
                    current = current.Prev;
                }
            }
            return current;
        }

        public bool Set(int index, string val)
        {
            DLLNode foundNode = Get(index);
            if (foundNode != null)
            {
                foundNode.Val = val;
                return true;
            }
            return false;
        }
    }
}