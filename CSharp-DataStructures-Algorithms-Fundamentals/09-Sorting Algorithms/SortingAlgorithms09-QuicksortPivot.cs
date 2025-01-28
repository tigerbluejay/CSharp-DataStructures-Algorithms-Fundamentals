using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static int Pivot(int[] arr, int start = 0, int end = -1)
        {
            if (end == -1)
                end = arr.Length - 1;

            void Swap(int[] array, int idx1, int idx2)
            {
                int temp = array[idx1];
                array[idx1] = array[idx2];
                array[idx2] = temp;
            }

            // Assuming the pivot is the first element
            int pivot = arr[start];
            int swapIdx = start;

            for (int i = start + 1; i <= end; i++)
            {
                if (pivot > arr[i])
                {
                    swapIdx++;
                    Swap(arr, swapIdx, i);
                }
            }

            // Swap the pivot from the start to the swap point
            Swap(arr, start, swapIdx);

            return swapIdx;
        }
    }
}

/*
Pivot(arrPQS, start=0, end=7)
Initial Array: { 4, 8, 2, 1, 5, 7, 6, 3 }
Pivot chosen: 4 (arr[0])

Comparisons and Swaps:
- Compare arr[1] = 8 with pivot 4 → No change
- Compare arr[2] = 2 with pivot 4 → Swap arr[1] and arr[2]
Array: { 4, 2, 8, 1, 5, 7, 6, 3 }
- Compare arr[3] = 1 with pivot 4 → Swap arr[2] and arr[3]
Array: { 4, 2, 1, 8, 5, 7, 6, 3 }
- Compare arr[4] = 5 with pivot 4 → No change
- Compare arr[5] = 7 with pivot 4 → No change
- Compare arr[6] = 6 with pivot 4 → No change
- Compare arr[7] = 3 with pivot 4 → Swap arr[3] and arr[7]
Array: { 4, 2, 1, 3, 5, 7, 6, 8 }

Final Swap (Place Pivot):
- Swap arr[0] and arr[3]
Array: { 3, 2, 1, 4, 5, 7, 6, 8 }

Result:
- Pivot index: 3
- Final Array: { 3, 2, 1, 4, 5, 7, 6, 8 }
*/