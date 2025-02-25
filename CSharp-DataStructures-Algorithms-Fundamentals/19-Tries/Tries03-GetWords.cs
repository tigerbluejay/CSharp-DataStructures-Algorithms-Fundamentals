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
		public List<string> GetWords(List<string> words = null, string currentWord = "")
		{
			// Initialize the list if it's null
			words ??= new List<string>();

			// If this node marks the end of a word, add the current word to the list
			if (IsWord)
			{
				words.Add(currentWord);
			}

			// Recursively collect words from all child nodes
			// The reason we can call GetWords on kvp.Value in the loop:
			// is that kvp.Value is itself an instance of Trie.
			foreach (var kvp in Characters)
			{
				kvp.Value.GetWords(words, currentWord + kvp.Key);
			}

			return words; // Return the collected words
		}
	}
}
