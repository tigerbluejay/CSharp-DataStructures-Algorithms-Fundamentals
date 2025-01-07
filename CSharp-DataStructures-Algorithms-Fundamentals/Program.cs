using System;
using System.Collections.Generic;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    class Program
    {
        public static void Main()
        {
            ////////////////////////////////////////////////////////////
            ////////////// 01- FREQUENCY COUNTERS //////////////////////
            ////////////////////////////////////////////////////////////

            Console.WriteLine("Frequency Counters");
            Console.WriteLine();
            Console.WriteLine(FrequencyCounters.SameFrequency(182, 281)); // true
            Console.WriteLine(FrequencyCounters.SameFrequency(34, 14)); // false
            Console.WriteLine(FrequencyCounters.SameFrequency(3589578, 5879385)); // true
            Console.WriteLine(FrequencyCounters.SameFrequency(22, 222)); // false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicates(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicates(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicates('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicates_FC(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicates_FC(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicates_FC('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP2(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP2(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP2('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.Same(new int[] { 1, 2, 3, 2 }, new List<int> { 9, 1, 4, 4 }));
            // Output: true or false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.SameRefactored(new int[] { 1, 2, 3, 2, 5 }, new int[] { 9, 1, 4, 4, 11 }));
            // Output: false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.ValidAnagram("anagrams", "nagaramm"));
            // Output: false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.ConstructNote("aa", "abc"));          // Output: false
            Console.WriteLine(FrequencyCounters.ConstructNote("abc", "dcba"));        // Output: true
            Console.WriteLine(FrequencyCounters.ConstructNote("aabbcc", "bcabcaddff")); // Output: true

            Console.WriteLine(string.Join(", ",
                FrequencyCounters.FindAllDuplicates(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
            // Output: 2, 3
            Console.WriteLine(string.Join(", ",
                FrequencyCounters.FindAllDuplicates(new int[] { 4, 3, 2, 1, 0 })));
            // Output: (empty)
            Console.WriteLine(string.Join(", ",
                FrequencyCounters.FindAllDuplicates(new int[] { 4, 3, 2, 1, 0, 1, 2, 3 })));
            // Output: 1, 2, 3

            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 6, 1, 4, 10, 2, 4 }, 2));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 8, 6, 2, 4, 1, 0, 2, 5, 13 }, 1));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 4, -2, 3, 10 }, -6));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 6, 1, 4, 10, 2, 4 }, 22));
            // Output: false
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { }, 0));
            // Output: false
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 5, 5 }, 0));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { -4, 4 }, -8));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { -4, 4 }, 8));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 1, 3, 4, 6 }, -2));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 0, 1, 3, 4, 6 }, -2));
            // Output: true
        }
    }
}
