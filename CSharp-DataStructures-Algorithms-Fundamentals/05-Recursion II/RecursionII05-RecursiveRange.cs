
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionII
    {
        public static int RecursiveRange(int x)
        {
            if (x == 0) return 0;
            return x + RecursiveRange(x - 1);
        }
    }
}

/*
RecursiveRange

Write a function called recursiveRange which accepts a number and adds 
up all the numbers from 0 to the number passed to the function.
*/