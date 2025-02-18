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
		private List<KeyValuePair<string, string>>[] keyMap;

		public HashTables(int size = 53)
		{
			keyMap = new List<KeyValuePair<string, string>>[size];
		}

		private int Hash(string key)
		{
			int total = 0;
			int WEIRD_PRIME = 31;
			int length = Math.Min(key.Length, 100);

			for (int i = 0; i < length; i++)
			{
				int value = key[i] - 'a' + 1;
				total = (total * WEIRD_PRIME + value) % keyMap.Length;
			}

			return total;
		}

		public void Set(string key, string value)
		{
			int index = Hash(key);
			if (keyMap[index] == null)
			{
				keyMap[index] = new List<KeyValuePair<string, string>>();
			}
			keyMap[index].Add(new KeyValuePair<string, string>(key, value));
		}

		public string Get(string key)
		{
			int index = Hash(key);
			if (keyMap[index] != null)
			{
				foreach (var pair in keyMap[index])
				{
					if (pair.Key == key)
					{
						return pair.Value;
					}
				}
			}
			return null;
		}

	}

}
