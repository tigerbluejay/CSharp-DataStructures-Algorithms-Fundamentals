using CSharp_DataStructures_Algorithms_Fundamentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class Trie
	{
		public Trie FindWord(string word, int index = 0)
		{
			if (index >= word.Length) return this;
			char ch = word[index];
			return Characters.ContainsKey(ch) ? Characters[ch].FindWord(word, index + 1) : null;
		}
	}
}
