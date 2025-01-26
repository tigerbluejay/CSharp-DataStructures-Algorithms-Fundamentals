using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static void OptimizedBubbleSort(int[] arr)
        {
            bool noSwaps;
            for (int i = arr.Length; i > 0; i--)
            {
                noSwaps = true;
                for (int j = 0; j < i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        noSwaps = false;
                    }
                }
                // If no swaps were made during the inner loop,
                // array is sorted
                if (noSwaps) break;
            }
        }
    }
}