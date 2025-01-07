namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    {
        public static List<int> FindAllDuplicates(int[] nums)
        {
            List<int> duplicates = new List<int>();
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Count the frequency of each number
            foreach (int num in nums)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            // Iterate through the frequency dictionary and find duplicates
            foreach (var entry in frequency)
            {
                // Find and return all the elements that appear twice
                if (entry.Value == 2)
                {
                    duplicates.Add(entry.Key);
                }
            }

            return duplicates;
        }


    }
}