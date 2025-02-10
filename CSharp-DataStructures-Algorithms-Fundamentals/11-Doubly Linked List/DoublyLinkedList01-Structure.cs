using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public class DLLNode
    {
        public string Val { get; set; }
        public DLLNode Next { get; set; }
        public DLLNode Prev { get; set; }

        public DLLNode(string val)
        {
            Val = val;
            Next = null;
            Prev = null;
        }
    }

    public partial class DoublyLinkedList
    {
        public DLLNode Head { get; private set; }
        public DLLNode Tail { get; private set; }
        public int Length { get; private set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }
    }
}
