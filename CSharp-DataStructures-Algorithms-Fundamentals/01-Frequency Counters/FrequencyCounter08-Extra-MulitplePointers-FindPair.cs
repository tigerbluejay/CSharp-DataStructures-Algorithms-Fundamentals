namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    {
        public static bool FindPair(int[] arr, int n)
        {
            if (arr.Length < 2)
            {
                return false;
            }

            HashSet<int> numSet = new HashSet<int>();

            foreach (int num in arr)
            {
                int complement1 = num - n;
                int complement2 = num + n;

                if (numSet.Contains(complement1) || numSet.Contains(complement2))
                {
                    return true;
                }

                numSet.Add(num);
            }

            return false;
        }
    }
}

/* Given an unsorted array and a number n, 
 * find if there exists a pair of elements 
 * in the array whose difference is n. 
 * This function should return true if the pair 
 * exists or false if it does not. */