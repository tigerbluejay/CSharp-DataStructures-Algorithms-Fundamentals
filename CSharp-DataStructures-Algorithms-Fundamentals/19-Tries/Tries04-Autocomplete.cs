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
		public List<string> AutoComplete(string prefix)
		{
			Trie node = FindWord(prefix);
			return node == null ? new List<string>() : node.GetWords().ConvertAll(word => prefix + word);
		}
	}
}

/*
The ConvertAll method in C# is used to transform each element in a List<T> into another type or format 
using a specified conversion function. It is part of the List<T> class and works similarly to Select in LINQ.

Syntax:
List<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter);

TOutput → The type of the elements in the new list.
converter → A delegate (function) that defines how to transform each element.

node.GetWords() returns a list of words stored in the Trie that match the prefix.
ConvertAll(word => prefix + word) transforms each word by prepending the prefix to it.
The transformed list is returned.

*/