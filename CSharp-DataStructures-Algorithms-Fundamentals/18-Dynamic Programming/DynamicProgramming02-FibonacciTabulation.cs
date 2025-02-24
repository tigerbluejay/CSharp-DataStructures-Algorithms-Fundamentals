using CSharp_DataStructures_Algorithms_Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class DynamicProgramming
	{
		/* Tabulation - Bottom-Up Approach
       Instead of recursion, we use an iterative approach to compute Fibonacci numbers.
       We store results in an array and build the solution progressively.
       
       This method is called "bottom-up" because we first compute Fibonacci(3), then Fibonacci(4), 
       Fibonacci(5), and so on, up to Fibonacci(n).
    */

		public static int FibonacciBottomUp(int n)
		{
			if (n <= 2) return 1;

			// Array to store computed Fibonacci numbers
			int[] fibonacciNumbers = new int[n + 1];
			fibonacciNumbers[1] = 1;
			fibonacciNumbers[2] = 1;

			// Iteratively compute Fibonacci numbers up to n
			for (int i = 3; i <= n; i++)
			{
				fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
			}

			return fibonacciNumbers[n];
		}

		/*
		   The bottom-up approach avoids issues like "maximum call stack size exceeded,"
		   which can occur in the recursive memoized version due to deep recursion.

		   While both the memoized and bottom-up versions have the same time complexity O(N),
		   the bottom-up approach is more space-efficient since it eliminates recursive function calls.
		*/
	}
}
