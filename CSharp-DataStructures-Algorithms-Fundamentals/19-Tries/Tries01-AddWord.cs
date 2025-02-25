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
		public Dictionary<char, Trie> Characters { get; private set; }
		public bool IsWord { get; private set; }

		public Trie()
		{
			Characters = new Dictionary<char, Trie>();
			IsWord = false;
		}

		public Trie AddWord(string word, int index = 0)
		{
			if (index == word.Length)
			{
				IsWord = true;
			}
			else if (index < word.Length)
			{
				char ch = word[index];
				if (!Characters.ContainsKey(ch))
				{
					Characters[ch] = new Trie();
				}
				Characters[ch].AddWord(word, index + 1);
			}
			return this;
		}
	}
}