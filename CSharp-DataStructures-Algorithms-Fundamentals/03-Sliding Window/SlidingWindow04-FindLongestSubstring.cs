namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public partial class SlidingWindow
    {
        public static int FindLongestSubstring(string str)
        {
            int longest = 0;
            Dictionary<char, int> seen = new Dictionary<char, int>();
            int start = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (seen.ContainsKey(c))
                {
                    // if a letter appears again (in seen) start
                    // will stop increasing
                    start = Math.Max(start, seen[c]);
                }

                // Update longest with the current length of the substring
                longest = Math.Max(longest, i - start + 1);

                // Store the index of the next occurrence of the character
                seen[c] = i + 1;
            }

            return longest;
        }
    }
}
/*
The algorithm finds the length of the longest substring in a given string that
contains only distinct (non-repeating) characters. It uses the sliding window
technique, which efficiently scans the string one character at a time while
keeping track of the longest substring without duplicates.
*/
/*
Input: "rithmschool"

Initial values:
├── longest = 0
├── seen = {}
└── start = 0

Loop through each character in the string:

At index 0 (char = 'r'): 
├── 'r' hasn't appeared before
├── Calculate substring length: 1 - 0 + 1 = 1
├── Update longest = 1
└── seen = {'r': 1}

At index 1 (char = 'i'): 
├── 'i' hasn't appeared before
├── Calculate substring length: 2 - 0 + 1 = 2
├── Update longest = 2
└── seen = {'r': 1, 'i': 2}

At index 2 (char = 't'): 
├── 't' hasn't appeared before
├── Calculate substring length: 3 - 0 + 1 = 3
├── Update longest = 3
└── seen = {'r': 1, 'i': 2, 't': 3}

At index 3 (char = 'h'): 
├── 'h' hasn't appeared before
├── Calculate substring length: 4 - 0 + 1 = 4
├── Update longest = 4
└── seen = {'r': 1, 'i': 2, 't': 3, 'h': 4}

At index 4 (char = 'm'): 
├── 'm' hasn't appeared before
├── Calculate substring length: 5 - 0 + 1 = 5
├── Update longest = 5
└── seen = {'r': 1, 'i': 2, 't': 3, 'h': 4, 'm': 5}

At index 5 (char = 's'): 
├── 's' hasn't appeared before
├── Calculate substring length: 6 - 0 + 1 = 6
├── Update longest = 6
└── seen = {'r': 1, 'i': 2, 't': 3, 'h': 4, 'm': 5, 's': 6}

At index 6 (char = 'c'): 
├── 'c' hasn't appeared before
├── Calculate substring length: 7 - 0 + 1 = 7
├── Update longest = 7
└── seen = {'r': 1, 'i': 2, 't': 3, 'h': 4, 'm': 5, 's': 6, 'c': 7}

At index 7 (char = 'h'): 
├── 'h' has appeared before (at index 3)
├── Update start = max(0, 4) = 4
├── Calculate substring length: 7 - 4 + 1 = 4 (longest remains 7)
└── seen = {'r': 1, 'i': 2, 't': 3, 'h': 8, 'm': 5, 's': 6, 'c': 7}

Final result:
└── longest = 7
*/

/*
Imagine the string as a "window" that keeps growing until you find a duplicate.
When a duplicate is found, adjust the start of the window to just past the last
occurrence of that duplicate. Thus is "rithmschool" the window moves to 7 (the c)
when the h is found, the widow restarts past the first h at the m with "msch" the new
window being 4. The window shrinks when a repeated value is found. Then when the o
comes along "mscho" is 5.


/*
Write a function called findLongestSubstring, which accepts a string 
and returns the length of the longest substring with all distinct characters.
*/