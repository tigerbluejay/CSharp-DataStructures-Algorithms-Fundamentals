using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIV
    {
        public static List<string> CapitalizeFirst(List<string> list)
        {
            if (list.Count == 1)
            {   // base case
                return new List<string> { list[0][0].ToString().ToUpper()
                    + list[0].Substring(1) };
            }

            List<string> res = CapitalizeFirst(list.GetRange(0, list.Count - 1));

            // upon returning the base case, this is called to capitalize the last word
            string str = list[list.Count - 1][0].ToString().ToUpper()
                + list[list.Count - 1].Substring(1);

            res.Add(str);
            return res;
        }

    }
}

/*
CapitalizeFirst(["hello", "world", "how", "are", "you"])
    └── CapitalizeFirst(["hello", "world", "how", "are"])
        └── CapitalizeFirst(["hello", "world", "how"])
            └── CapitalizeFirst(["hello", "world"])
                └── CapitalizeFirst(["hello"])
                    └── Base case: return ["Hello"]
                └── Add "World" (capitalize last word in ["hello", "world"])
                └── Result: ["Hello", "World"]
            └── Add "How" (capitalize last word in ["hello", "world", "how"])
            └── Result: ["Hello", "World", "How"]
        └── Add "Are" (capitalize last word in ["hello", "world", "how", "are"])
        └── Result: ["Hello", "World", "How", "Are"]
    └── Add "You" (capitalize last word in ["hello", "world", "how", "are", "you"])
    └── Result: ["Hello", "World", "How", "Are", "You"]
*/
/*
The list is being shortened successively in this part of the algorithm:

List<string> res = CapitalizeFirst(list.GetRange(0, list.Count - 1));

Explanation:
What happens here?
The method list.GetRange(0, list.Count - 1) creates a new list that excludes
the last element of the current list. For example:

For list = ["hello", "world", "how", "are", "you"],
list.GetRange(0, list.Count - 1) will return ["hello", "world", "how", "are"].
On the next recursive call, the shortened list becomes ["hello", "world", "how"],
and so on.
*/
/*
CapitalizeFirst

Write a recursive function called capitalizeFirst. 
Given an list of strings, capitalize the first letter of each 
string in the list.
*/