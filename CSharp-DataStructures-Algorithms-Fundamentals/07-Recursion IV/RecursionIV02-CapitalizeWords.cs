using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIV
    {
        public static List<string> CapitalizeWords(List<string> list)
        {
            if (list.Count == 1)
            {
                return new List<string> { list[0].ToUpper() };
            }

            List<string> res = CapitalizeWords(list.GetRange(0, list.Count - 1));

            // not only arrays, but lists too start at index 0 in C#
            res.Add(list[list.Count - 1].ToUpper());

            return res;
        }

    }
}

/*
CapitalizeWords(["hello", "world", "how", "are", "you"])
    └── CapitalizeWords(["hello", "world", "how", "are"])
        └── CapitalizeWords(["hello", "world", "how"])
            └── CapitalizeWords(["hello", "world"])
                └── CapitalizeWords(["hello"])
                    └── Base case: return ["HELLO"]
                └── Add "WORLD" (capitalize last word in ["hello", "world"])
                └── Result: ["HELLO", "WORLD"]
            └── Add "HOW" (capitalize last word in ["hello", "world", "how"])
            └── Result: ["HELLO", "WORLD", "HOW"]
        └── Add "ARE" (capitalize last word in ["hello", "world", "how", "are"])
        └── Result: ["HELLO", "WORLD", "HOW", "ARE"]
    └── Add "YOU" (capitalize last word in ["hello", "world", "how", "are", "you"])
    └── Result: ["HELLO", "WORLD", "HOW", "ARE", "YOU"]
*/
/*
CapitalizeWords

Write a recursive function called capitalizeWords. 
Given an list of words, return a new list containing 
each word capitalized.
*/