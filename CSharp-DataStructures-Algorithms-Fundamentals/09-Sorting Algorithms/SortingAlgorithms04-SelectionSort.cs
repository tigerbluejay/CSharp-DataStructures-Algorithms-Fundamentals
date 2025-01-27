using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int lowest = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[lowest] > arr[j])
                    {
                        lowest = j;
                    }
                }
                if (i != lowest)
                {
                    Swap(arr, i, lowest);
                }
            }
        }

        static void Swap(int[] arr, int idx1, int idx2)
        {
            int temp = arr[idx1];
            arr[idx1] = arr[idx2];
            arr[idx2] = temp;
        }
    }
}

/*
Initial Array: [0, 2, 34, 22, 10, 19, 17]

Pass 1 (i = 0):

Assume lowest = 0 (value = 0).
Compare arr[0] with all other elements:
arr[0] (0) ≤ arr[1] (2) → no change.
arr[0] (0) ≤ arr[2] (34) → no change.
arr[0] (0) ≤ arr[3] (22) → no change.
arr[0] (0) ≤ arr[4] (10) → no change.
arr[0] (0) ≤ arr[5] (19) → no change.
arr[0] (0) ≤ arr[6] (17) → no change.
No swap needed.
Array after Pass 1: [0, 2, 34, 22, 10, 19, 17]
Pass 2 (i = 1):

Assume lowest = 1 (value = 2).
Compare arr[1] with all other elements:
arr[1] (2) ≤ arr[2] (34) → no change.
arr[1] (2) ≤ arr[3] (22) → no change.
arr[1] (2) ≤ arr[4] (10) → no change.
arr[1] (2) ≤ arr[5] (19) → no change.
arr[1] (2) ≤ arr[6] (17) → no change.
No swap needed.
Array after Pass 2: [0, 2, 34, 22, 10, 19, 17]
Pass 3 (i = 2):

Assume lowest = 2 (value = 34).
Compare arr[2] with all other elements:
arr[2] (34) > arr[3] (22) → lowest = 3.
arr[3] (22) > arr[4] (10) → lowest = 4.
arr[4] (10) ≤ arr[5] (19) → no change.
arr[4] (10) ≤ arr[6] (17) → no change.
Swap arr[2] with arr[4].
Array after Pass 3: [0, 2, 10, 22, 34, 19, 17]

partial output
*/