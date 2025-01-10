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

            ////////////////////////////////////////////////////////////
            ////////////// 02- MULTIPLE POINTERS ///////////////////////
            ////////////////////////////////////////////////////////////

            Console.WriteLine("Multiple Pointers");
            Console.WriteLine();

            Console.WriteLine(MultiplePointers.CountUniqueValues(new int[] { 1, 2, 2, 5, 7, 7, 99 }));
            // Output: 5

            Console.WriteLine(MultiplePointers.SumZeroNaive(new int[] { -4, -3, -2, -1, 0, 1, 2, 5 }));
            Console.WriteLine(MultiplePointers.NewSumZero(new int[] { -4, -3, -2, -1, 0, 1, 2, 3, 10 }));

            Console.WriteLine(MultiplePointers.IsSubsequenceIterative("abc", "ahbgdc")); // Output: true
            Console.WriteLine(MultiplePointers.IsSubsequenceRecursive("abc", "ahbgdc"));

            Console.WriteLine(MultiplePointers.AveragePair(new int[] { 1, 2, 3 }, 2.5)); // true
            Console.WriteLine(MultiplePointers.AveragePair(new int[] { 1, 3, 3, 5, 6, 7, 10, 12, 19 }, 8)); // true
            Console.WriteLine(MultiplePointers.AveragePair(new int[] { -1, 0, 3, 4, 5, 6 }, 4.1)); // false
            Console.WriteLine(MultiplePointers.AveragePair(new int[] { }, 4)); // false

            ////////////////////////////////////////////////////////////
            ////////////// 03- SLIDING WINDOW //////////////////////////
            ////////////////////////////////////////////////////////////

            Console.WriteLine(SlidingWindow.MaxSubarraySum(new int[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 }, 3));
            Console.WriteLine(SlidingWindow.MaxSubarraySum2(new int[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 }, 3));

            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 100, 200, 300, 400 }, 2)); // 700
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 1, 4, 2, 10, 23, 3, 1, 0, 20 }, 4)); // 39
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { -3, 4, 0, -2, 6, -1 }, 2)); // 5
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 3, -2, 7, -4, 1, -1, 4, -2, 1 }, 2)); // 5
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 2, 3 }, 3)); // null

            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 2, 3, 1, 2, 4, 3 }, 7)); // 2
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 2, 1, 6, 5, 4 }, 9));    // 2
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 3, 1, 7, 11, 2, 9, 8, 21, 62, 33, 19 }, 52)); // 1
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 39));         // 3
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 55));         // 5
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 4, 3, 3, 8, 1, 2, 3 }, 11));                 // 2
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 95));         // 0

            Console.WriteLine(SlidingWindow.FindLongestSubstring("rithmschool")); // Output: 7
            Console.WriteLine(SlidingWindow.FindLongestSubstring("thisisawesome")); // Output: 6
            Console.WriteLine(SlidingWindow.FindLongestSubstring("thecatinthehat")); // Output: 7
            Console.WriteLine(SlidingWindow.FindLongestSubstring("bbbbbbb")); // Output: 1
            Console.WriteLine(SlidingWindow.FindLongestSubstring("longestsubstring")); // Output: 8
            Console.WriteLine(SlidingWindow.FindLongestSubstring("thisishowwedoit")); // Output: 6
        }
    }
}
