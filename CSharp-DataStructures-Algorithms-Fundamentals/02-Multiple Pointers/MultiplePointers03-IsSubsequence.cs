namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;

    public static partial class MultiplePointers
    {
        public static bool IsSubsequenceIterative(string str1, string str2)
        {
            int i = 0;
            int j = 0;

            if (string.IsNullOrEmpty(str1)) return true;

            while (j < str2.Length)
            {
                if (str2[j] == str1[i]) i++;
                if (i == str1.Length) return true;
                j++;
            }

            return false;
        }


        public static bool IsSubsequenceRecursive(string str1, string str2)
        {
            if (str1.Length == 0) return true;
            if (str2.Length == 0) return false;

            if (str2[0] == str1[0])
            {
                return IsSubsequenceRecursive(str1.Substring(1), str2.Substring(1));
            }

            return IsSubsequenceRecursive(str1, str2.Substring(1));
        }
    }
}
        /*
        IsSubsequenceRecursive("abc", "ahbgdc")
        ├── str1[0] == str2[0] ? 'a' == 'a' (True)

        │   └── IsSubsequenceRecursive("bc", "hbgdc")
        │       ├── str1[0] == str2[0] ? 'b' == 'h' (False)
        │       │   └── IsSubsequenceRecursive("bc", "bgdc")
        │       │       ├── str1[0] == str2[0] ? 'b' == 'b' (True)

        │       │       │   └── IsSubsequenceRecursive("c", "gdc")
        │       │       │       ├── str1[0] == str2[0] ? 'c' == 'g' (False)
        │       │       │       │   └── IsSubsequenceRecursive("c", "dc")
        │       │       │       │       ├── str1[0] == str2[0] ? 'c' == 'd' (False)
        │       │       │       │       │   └── IsSubsequenceRecursive("c", "c")
        │       │       │       │       │       ├── str1[0] == str2[0] ? 'c' == 'c' (True)

        │       │       │       │       │       │   └── IsSubsequenceRecursive("", "")
        │       │       │       │       │       │       └── Return true (base case reached)

        │       │       │       │       │       └── Return true
        │       │       │       │       └── Return true
        │       │       │       └── Return true
        │       │       └── Return true
        │       └── Return true
        └── Return true
        */

/*
The line if (str1.Length == 0) return true; only executes once, and that happens when
str1 has been completely reduced to an empty string ("") through recursive slicing.
At this point, the function hits its base case and returns true.

Once that first true is returned, it propagates back up through the recursive call stack,
and every previous function call simply returns that same true.
*/

/*
Multiple Pointers - isSubsequence

Write a function called isSubsequence which takes in two strings and checks
whether the characters in the first string form a subsequence of the
characters in the second string. 

In other words, the function should check whether the characters in the 
first string appear somewhere in the second string, without their order changing.

Examples:

isSubsequence('hello', 'hello world'); // true
isSubsequence('sing', 'sting'); // true
isSubsequence('abc', 'abracadabra'); // true
isSubsequence('abc', 'acb'); // false (order matters)

Your solution MUST have AT LEAST the following complexities:

Time Complexity - O(N + M)
Space Complexity - O(1)
*/