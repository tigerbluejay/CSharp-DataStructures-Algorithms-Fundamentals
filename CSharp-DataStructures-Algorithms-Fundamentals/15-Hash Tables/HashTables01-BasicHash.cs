using CSharp_DataStructures_Algorithms_Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class HashTables
	{
		public static int Hash(string key, int arrayLen)
		{
			int total = 0;
			foreach (char c in key)
			{
				// map "a" to 1, "b" to 2, "c" to 3, etc.
				int value = c - 'a' + 1;
				total = (total + value) % arrayLen;
			}
			return total;
		}
	}
}

/*
The person who developed this algorithm was likely trying to illustrate the basic principles of hashing 
in a simple and intuitive way. Here’s what they were conveying about hash tables with this example:

Hashing Converts Keys into Indexes

The function maps a string key to a numeric index within a fixed array size (arrayLen).
This demonstrates how hash functions enable efficient storage and retrieval in hash tables.

Character-Based Hashing

By mapping characters ('a' → 1, 'b' → 2, etc.), the function shows how simple transformations can be used to generate a numeric hash.
This method is intuitive for beginners and emphasizes that hash functions can be based on ASCII or character encoding.

Modulo Operation for Array Boundaries

The % arrayLen operation ensures that the computed hash falls within the valid index range.
This demonstrates how hash functions distribute values across a fixed-size table.

Collisions & Improvements

The function lacks a prime multiplier or bit-shifting techniques to better distribute values, so it likely produces more collisions.
This suggests that while basic hash functions work, real-world implementations require more complexity to reduce collisions.

Key Takeaway
The example provides a fundamental and accessible way to understand hashing without overwhelming complexity. 
It lays the groundwork for discussing improvements like prime numbers, polynomial rolling hashes, and 
collision resolution techniques (e.g., chaining, open addressing).

*/