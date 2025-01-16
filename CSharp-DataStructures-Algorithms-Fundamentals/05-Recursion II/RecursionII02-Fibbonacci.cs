using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionII
    {
        public static int Fibonacci(int n)
        {
            if (n <= 2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

/*
The output of the Fibonacci(5) function is 5.

Here’s the step-by-step breakdown:

Fibonacci(5) = Fibonacci(4) + Fibonacci(3)
    Fibonacci(4) = Fibonacci(3) + Fibonacci(2)
        Fibonacci(3) = Fibonacci(2) + Fibonacci(1)
                Fibonacci(2) = 1 (base case)
                Fibonacci(1) = 1 (base case)

        So, Fibonacci(3) = 1 + 1 = 2
                Fibonacci(2) = 1 (base case)

    So, Fibonacci(4) = 2 + 1 = 3
        Fibonacci(3) = Fibonacci(2) + Fibonacci(1)
                Fibonacci(2) = 1 (base case)
                Fibonacci(1) = 1 (base case)
        So, Fibonacci(3) = 1 + 1 = 2

So, Fibonacci(5) = 3 + 2 = 5
*/

/*
Fibonacci

Write a recursive function called Fibonacci which accepts a number and 
returns the nth number in the Fibonacci sequence. Recall that the 
Fibonacci sequence is the sequence of whole numbers 1, 1, 2, 3, 5, 8, ... 
which starts with 1 and 1, and where every number thereafter is equal 
to the sum of the previous two numbers.
*/