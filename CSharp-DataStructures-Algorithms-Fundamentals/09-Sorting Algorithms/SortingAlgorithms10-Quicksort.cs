using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the pivot index
                int pivotIndex = Pivot(arr, left, right);

                // Sort the left part
                QuickSort(arr, left, pivotIndex - 1);
                // Sort the right part
                QuickSort(arr, pivotIndex + 1, right);
            }
        }
    }
}
/*

// [4,6,9,1,2,5,3] ---> starting point is "4"
// [3,2,1,4,6,9,5]
//        4        ---> it is put in place (by the pivot function)
//  3,2,1    6,9,5 ---> starting points are 3 and 6 respectively
//      3      6   ---> they are put in place (by thepivot function)
//  2,1      5  9  ---> starting point is 2
//    2            ---> it is put in place (by the pivot function)
//  1
  
  
  // the pivot function puts the pivot in place and returns
  // its position once it has been correctly sorted
  // So the pivot is 4, it sorts it into proper location
  // and returns its index,
  // which is used in the quicksort functions to further
  // call the pivot function, returning the now ordered pivot's index
  // which helps set the new limits for quicksort calls.
  

QuickSort(arr, left=0, right=6)  
  Pivot: 4, PivotIndex: 3  
  Array: { 3, 2, 1, 4, 9, 5, 6 }

  ├── QuickSort(arr, left=0, right=2)  
  │     Pivot: 3, PivotIndex: 2  
  │     Array: { 1, 2, 3, 4, 9, 5, 6 }  
  │  
  │     ├── QuickSort(arr, left=0, right=1)  
  │     │     Pivot: 1, PivotIndex: 0  
  │     │     Array: { 1, 2, 3, 4, 9, 5, 6 }  
  │     │     ├── QuickSort(arr, left=0, right=-1) → Return  
  │     │     └── QuickSort(arr, left=1, right=1) → Return  
  │  
  │     └── QuickSort(arr, left=3, right=2) → Return  
  │  
  └── QuickSort(arr, left=4, right=6)  
        Pivot: 9, PivotIndex: 6  
        Array: { 1, 2, 3, 4, 6, 5, 9 }  
        ├── QuickSort(arr, left=4, right=5)  
        │     Pivot: 6, PivotIndex: 5  
        │     Array: { 1, 2, 3, 4, 5, 6, 9 }  
        │     ├── QuickSort(arr, left=4, right=4) → Return  
        │     └── QuickSort(arr, left=6, right=5) → Return  
        └── QuickSort(arr, left=7, right=6) → Return
*/