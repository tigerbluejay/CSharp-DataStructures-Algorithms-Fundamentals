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
		/* Coin Change Problem - Dynamic Programming (Tabulation)
       This approach determines how many ways we can make change for a given amount
       using a set of coin denominations.

       We use a bottom-up approach by iterating over each coin and updating the ways 
       we can make change for all amounts up to the target value.
    */

		public static int CountWaysToMakeChange(int[] denominations, int targetAmount)
		{
			// Array to store the number of ways to make change for each amount
			int[] ways = new int[targetAmount + 1];

			// There is exactly one way to make change for 0 (using no coins)
			ways[0] = 1;

			// Process each coin denomination
			foreach (int coin in denominations)
			{
				// Update the ways to make change for all amounts starting from the coin's value
				for (int amount = coin; amount <= targetAmount; amount++)
				{
					ways[amount] += ways[amount - coin];
				}
			}

			return ways[targetAmount];
		}

		//static void Main()
		//{
		//	int[] denominations = { 1, 5, 10, 25 };

		//	Console.WriteLine(CountWaysToMakeChange(denominations, 1));    // 1
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 2));    // 1
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 5));    // 2
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 10));   // 4
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 25));   // 13
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 45));   // 39
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 100));  // 242
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 145));  // 622
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 1451)); // 425663
		//	Console.WriteLine(CountWaysToMakeChange(denominations, 14511));// 409222339
		//}
	}
}

/*
Example Walkthrough
Let's go step by step with a simple example:

Problem:
Denominations: {1, 2, 5}
Target Amount: 5

Step 1: Initialize ways[]
ways = [1, 0, 0, 0, 0, 0]
ways[0] = 1 because there is one way to make 0 (using no coins).
All other values are 0 initially.

Step 2: Process Coin 1
Updating ways[] for amounts 1 to 5:
ways[1] += ways[1-1] → ways[1] = 1
ways[2] += ways[2-1] → ways[2] = 1
ways[3] += ways[3-1] → ways[3] = 1
ways[4] += ways[4-1] → ways[4] = 1
ways[5] += ways[5-1] → ways[5] = 1
Updated ways[]:
[1, 1, 1, 1, 1, 1]

Step 3: Process Coin 2
Updating ways[] for amounts 2 to 5:
ways[2] += ways[2-2] → ways[2] = 2
ways[3] += ways[3-2] → ways[3] = 2
ways[4] += ways[4-2] → ways[4] = 3
ways[5] += ways[5-2] → ways[5] = 3
Updated ways[]:
[1, 1, 2, 2, 3, 3]

Step 4: Process Coin 5
Updating ways[] for amounts 5:
ways[5] += ways[5-5] → ways[5] = 4
Final ways[]:
[1, 1, 2, 2, 3, 4]
Answer: 4 ways to make 5 using {1, 2, 5}.
*/