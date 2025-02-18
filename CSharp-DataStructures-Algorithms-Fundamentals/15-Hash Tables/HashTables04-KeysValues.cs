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
		public List<string> Keys()
		{
			List<string> keysArr = new List<string>();
			foreach (var bucket in keyMap)
			{
				if (bucket != null)
				{
					foreach (var pair in bucket)
					{
						if (!keysArr.Contains(pair.Key))
						{
							keysArr.Add(pair.Key);
						}
					}
				}
			}
			return keysArr;
		}

		public List<string> Values()
		{
			List<string> valuesArr = new List<string>();
			foreach (var bucket in keyMap)
			{
				if (bucket != null)
				{
					foreach (var pair in bucket)
					{
						if (!valuesArr.Contains(pair.Value))
						{
							valuesArr.Add(pair.Value);
						}
					}
				}
			}
			return valuesArr;
		}

	}
}

/*
The Keys() method iterates through the hash table and collects all the unique keys into a list.
The Values() method does the same but collects the unique values instead.

These methods ensure that:

They traverse all buckets in the hash table.
They extract the keys or values from each stored key-value pair.
They prevent duplicates by checking if the key or value is already in the list before adding it.

This way, they return a complete set of all stored keys and values, even in the presence of collisions 
where multiple key-value pairs exist in a single bucket.
*/