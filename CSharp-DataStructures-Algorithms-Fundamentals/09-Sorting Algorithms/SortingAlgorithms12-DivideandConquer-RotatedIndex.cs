using System;
using System.Collections.Generic;
using System.Linq;

/*
The algorithm is called "rotated index" because it is designed to find the position of a target element in a rotated sorted array.

What is a rotated sorted array?
A rotated sorted array is an array that was originally sorted in ascending order but then rotated at some pivot point. This means part of the array is moved to the end of the array while the original order remains intact for the rest of the array. For example:

Original sorted array: [1, 2, 3, 4, 5, 6, 7]
Rotated array (pivoted at index 3): [4, 5, 6, 7, 1, 2, 3]
*/


namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static int FindRotatedIndex(int[] arr, int target)
        {
            // Handle empty array or single element
            if (arr.Length == 0) return -1;
            if (arr.Length == 1) return arr[0] == target ? 0 : -1;

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                // Check if target is the middle element
                if (arr[mid] == target) return mid;

                // in a sorted rotated array the left OR the right
                // part must be sorted

                // If the left part is sorted
                if (arr[left] <= arr[mid])
                {
                    // Check if target is within the sorted left part
                    if (target >= arr[left] && target < arr[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else // Right part is sorted
                {
                    // Check if target is within the sorted right part
                    if (target > arr[mid] && target <= arr[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            // Target not found
            return -1;
        }

    }
}

/*
findRotatedIndex([6, 7, 8, 9, 1, 2, 3, 4], target = 8)
   left = 0, right = 7
   mid = (0 + 7) / 2 = 3
   arr[mid] = 9
   arr[left] = 6, arr[mid] = 9, arr[right] = 4
   Target is not equal to mid
   Left part is sorted: arr[left] = 6, arr[mid] = 9
   Target is in the left part. Move right to mid - 1
   New left = 0, right = 2

findRotatedIndex([6, 7, 8, 9, 1, 2, 3, 4], target = 8)
   left = 0, right = 2
   mid = (0 + 2) / 2 = 1
   arr[mid] = 7
   arr[left] = 6, arr[mid] = 7, arr[right] = 8
   Target is not equal to mid
   Left part is sorted: arr[left] = 6, arr[mid] = 7
   Target is in the right part. Move left to mid + 1
   New left = 2, right = 2

findRotatedIndex([6, 7, 8, 9, 1, 2, 3, 4], target = 8)
   left = 2, right = 2
   mid = (2 + 2) / 2 = 2
   arr[mid] = 8
   Target found at index 2
   Return 2
*/