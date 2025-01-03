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

            Console.WriteLine(FrequencyCounters2.AreThereDuplicates(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters2.AreThereDuplicates(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters2.AreThereDuplicates('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters2.AreThereDuplicates_FC(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters2.AreThereDuplicates_FC(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters2.AreThereDuplicates_FC('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(MultiplePointers.AreThereDuplicates(1, 2, 3)); // false
            Console.WriteLine(MultiplePointers.AreThereDuplicates(1, 2, 2)); // true
            Console.WriteLine(MultiplePointers.AreThereDuplicates('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(MultiplePointers.AreThereDuplicates_MP(1, 2, 3)); // false
            Console.WriteLine(MultiplePointers.AreThereDuplicates_MP(1, 2, 2)); // true
            Console.WriteLine(MultiplePointers.AreThereDuplicates_MP('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            int[] sameArray = { 1, 2, 3, 2 };
            List<int> sameList = new List<int> { 9, 1, 4, 4 };
            bool sameResult = FrequencyCounters3.Same(sameArray, sameList);
            Console.WriteLine(sameResult); // Output: true or false

            int[] sameArray2 = { 1, 2, 3, 2, 5 };
            int[] sameArray3 = { 9, 1, 4, 4, 11 };
            bool sameResult2 = FrequencyCounters4.SameRefactored(sameArray2, sameArray3);
            Console.WriteLine(sameResult2); // Output: false

            bool anagramResult = FrequencyCounters5.ValidAnagram("anagrams", "nagaramm");
            Console.WriteLine(anagramResult); // Output: false

        }
    }
}
