using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SearchingAlgorithms
    {

        public static int LinearSearch(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    return i; // Return the index if found
                }
            }
            return -1; // Return -1 if not found
        }
    }
}