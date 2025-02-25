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
		public void RemoveWord(string word, int index = 0)
		{
			// Base case: If we have reached the end of the word, mark this node as not a word.
			if (index == word.Length)
			{
				IsWord = false;
				return;
			}

			// Get the current character in the word.
			char charKey = word[index];

			// If the character does not exist in the Trie, the word is not present, so return.
			if (!Characters.ContainsKey(charKey))
			{
				return;
			}

			// Recursively call RemoveWord on the next character in the Trie.
			Trie subTrie = Characters[charKey];
			subTrie.RemoveWord(word, index + 1);

			// If the subTrie has no remaining children and does not mark the end of another word,
			// remove this character entry from the dictionary to clean up unused nodes.
			if (subTrie.Characters.Count == 0 && !subTrie.IsWord)
			{
				Characters.Remove(charKey);
			}
		}
	}
}
