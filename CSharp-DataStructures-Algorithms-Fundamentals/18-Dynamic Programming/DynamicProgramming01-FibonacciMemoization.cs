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
		/* 
		Dynamic Programming is useful for problems that have:
		1. Overlapping subproblems – The same subproblems are solved multiple times.
		2. Optimal substructure – The solution to a problem depends on solutions to its subproblems.
		
		 Example: Fibonacci sequence
		This is a naive recursive approach (not using dynamic programming)
		*/

		public static int Fibonacci(int n)
		{
			if (n <= 2) return 1;
			return Fibonacci(n - 1) + Fibonacci(n - 2);
		}

		/* 
		This solution has an exponential time complexity: O(2^N)
		It becomes extremely slow for large values of N.

		The issue is redundant calculations.
		For example, when computing Fibonacci(5), Fibonacci(3) is computed twice.
		When computing Fibonacci(6), Fibonacci(4) is computed twice, and Fibonacci(3) is computed three times.

		These redundant calculations show overlapping subproblems.

		Additionally, Fibonacci(3) is an essential part of computing Fibonacci(5),
		which demonstrates the optimal substructure property.
		*/
		
		/* DYNAMIC PROGRAMMING APPROACH
		 To optimize, we can store results of subproblems to avoid recomputation.
		 This technique is called Memoization.
		 We use a Dictionary to store previously computed values.
		*/

		public static int FibonacciMemoized(int n, Dictionary<int, int> memo = null)
		{
			// Initialize memoization storage if not provided
			if (memo == null)
				memo = new Dictionary<int, int>();

			// If we've already computed Fibonacci(n), return the stored result.
			if (memo.ContainsKey(n)) return memo[n];

			if (n <= 2) return 1;

			// Compute and store the result to avoid redundant calculations.
			memo[n] = FibonacciMemoized(n - 1, memo) + FibonacciMemoized(n - 2, memo);

			return memo[n];
		}
	}
}
