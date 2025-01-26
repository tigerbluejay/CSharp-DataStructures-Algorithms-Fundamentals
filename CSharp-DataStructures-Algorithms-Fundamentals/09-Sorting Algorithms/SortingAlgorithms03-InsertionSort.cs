using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static void InsertionSort(int[] arr)
        {
            int currentVal;
            for (int i = 1; i < arr.Length; i++)
            {
                currentVal = arr[i];
                int j = i - 1;

                // Shift elements of the sorted portion to the right
                while (j >= 0 && arr[j] > currentVal)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Insert the current element into its correct position
                arr[j + 1] = currentVal;
            }
        }
    }
}

/*
Initial Array: [2, 1, 9, 76, 4]

Iteration 1 (i=1, currentVal=1):
  Comparing 1 with 2: Move 2 to the right.
  Array after iteration 1: [1, 2, 9, 76, 4]

Iteration 2 (i=2, currentVal=9):
  Comparing 9 with 2: No change, 9 is greater than 2.
  Array after iteration 2: [1, 2, 9, 76, 4]

Iteration 3 (i=3, currentVal=76):
  Comparing 76 with 9: No change, 76 is greater than 9.
  Array after iteration 3: [1, 2, 9, 76, 4]

Iteration 4 (i=4, currentVal=4):
  Comparing 4 with 76: Move 76 to the right.
  Comparing 4 with 9: Move 9 to the right.
  Comparing 4 with 2: No change, 4 is greater than 2.
  Array after iteration 4: [1, 2, 4, 9, 76]

Final Sorted Array: [1, 2, 4, 9, 76]
*/