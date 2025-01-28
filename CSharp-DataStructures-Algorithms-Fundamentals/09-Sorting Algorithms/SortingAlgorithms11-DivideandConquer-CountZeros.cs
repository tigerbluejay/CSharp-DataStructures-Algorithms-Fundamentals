using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static int CountZeroes(int[] arr)
        {
            if (arr.Length == 0) return 0;

            return CountZeroesHelper(arr, 0, arr.Length - 1);
        }

        private static int CountZeroesHelper(int[] arr, int low, int high)
        {
            if (low > high) return 0;

            int mid = (low + high) / 2;

            if (arr[mid] == 0)
            {
                /*
                If the middle element is 0, calculate the number of zeroes 
                from the current midpoint to the end of the array.
                Then recursively search for any remaining zeroes in the left subarray.
                */
                return (high - mid + 1) + CountZeroesHelper(arr, low, mid - 1);
            }
            else
            {
                /*
                If the middle element is 1, all zeroes must be in the right subarray.
                Recursively search the right half of the array.
                */
                return CountZeroesHelper(arr, mid + 1, high);
            }
        }
    }
}

/*
The divide-and-conquer approach relies on the array being sorted 
for efficient searching of the transition point between 1s and 0s. 
This wouldn't work for an unsorted array.
*/

/*
This algorithm checks recursively using a binary search style and 
infers how many zeroes there are.

Here's a breakdown of how it works:

1. The approach leverages the sorted nature of the array, where all 1s 
   are grouped before all 0s. It efficiently finds the transition point 
   between the two sections.
2. At each recursive step:
   - If the middle element is 1, zeroes must be in the right subarray.
     We move to the right half.
   - If the middle element is 0, we calculate the number of zeroes in 
     the current subarray (from mid to high) and continue searching 
     the left subarray for additional zeroes.
3. By dividing the array into smaller parts and leveraging the sorted 
   order, we efficiently count the zeroes.
*/

/*
Input: new int[] { 1, 1, 1, 1, 0, 0 })
CountZeroes(arr, low=0, high=5)
  mid = 2, arr[mid] = 1 → Search right subarray
  └── CountZeroes(arr, low=3, high=5)
        mid = 4, arr[mid] = 0 → Count zeroes from mid to high (5 - 4 + 1 = 2) 
        ├── CountZeroes(arr, low=3, high=3)
        │     mid = 3, arr[mid] = 1 → Search right subarray
        │     └── CountZeroes(arr, low=4, high=3) → Return 0
        └── Return (2 + 0) = 2
  └── Return 2
*/