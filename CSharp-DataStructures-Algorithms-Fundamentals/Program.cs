using System;

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



        }
    }
}
