namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    {

        public static bool SameRefactored(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            Dictionary<int, int> frequencyCounter1 = new Dictionary<int, int>();
            Dictionary<int, int> frequencyCounter2 = new Dictionary<int, int>();

            // Build frequencyCounter1
            foreach (int val in arr1)
            {
                if (frequencyCounter1.ContainsKey(val))
                {
                    frequencyCounter1[val]++;
                }
                else
                {
                    frequencyCounter1[val] = 1;
                }
            }

            // Build frequencyCounter2
            foreach (int val in arr2)
            {
                if (frequencyCounter2.ContainsKey(val))
                {
                    frequencyCounter2[val]++;
                }
                else
                {
                    frequencyCounter2[val] = 1;
                }
            }

            // Debugging: Print frequency counters (optional)
            foreach (var pair in frequencyCounter1)
            {
                Console.WriteLine($"frequencyCounter1[{pair.Key}] = {pair.Value}");
            }

            foreach (var pair in frequencyCounter2)
            {
                Console.WriteLine($"frequencyCounter2[{pair.Key}] = {pair.Value}");
            }

            // Compare frequency counters
            foreach (var key in frequencyCounter1.Keys)
            {
                int squaredKey = key * key;

                if (!frequencyCounter2.ContainsKey(squaredKey))
                {
                    return false;
                }

                if (frequencyCounter2[squaredKey] != frequencyCounter1[key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

/*
/*
Write a function called same.
The function accepts two arrays
The function should return true if every value in the array
has its corresponding value squared in the second array 
(not necessarily in the same order in both arrays)
The frecuency of values should be the same.
*/