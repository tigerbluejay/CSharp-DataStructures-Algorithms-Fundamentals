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
		public static int Hash2(string key, int arrayLen)
		{
			int total = 0;
			int WEIRD_PRIME = 31;
			int length = Math.Min(key.Length, 100);

			for (int i = 0; i < length; i++)
			{
				char c = key[i];
				int value = c - 'a' + 1;
				total = (total * WEIRD_PRIME + value) % arrayLen;
			}

			return total;
		}
	}
}

/*
This refined hash function introduces two key improvements that help demonstrate important hashing table concepts:

1. Better Distribution with a Prime Multiplier
The introduction of WEIRD_PRIME = 31 improves the spread of hash values across the hash table.

Why a prime number?
Prime numbers help reduce patterns in the hash output, leading to fewer collisions.
Multiplying by a prime ensures that even small changes in input produce 
widely different hash values, a property called avalanche effect.

2. Limiting Iterations to 100 Characters
The loop runs for at most Math.min(key.length, 100), ensuring:
Efficiency: Long strings don’t cause excessive computation.
Consistency: Hash values remain manageable and don’t vary wildly for extremely long inputs.

This technique highlights the importance of hashing performance in real-world applications where speed is crucial.

Key Takeaways About Hash Tables
Prime Multipliers Reduce Collisions → A well-designed hash function spreads values efficiently.
Performance Optimization → Limiting the length prevents unnecessary computation, making hashing scalable.
Improved Hashing Techniques → This example serves as an introduction to better hashing methods used in real-world applications.
*/