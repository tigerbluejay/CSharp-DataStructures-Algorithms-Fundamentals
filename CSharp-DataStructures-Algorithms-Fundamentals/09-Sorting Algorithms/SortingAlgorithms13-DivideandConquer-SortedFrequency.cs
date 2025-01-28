using System;
using System.Collections.Generic;
using System.Linq;

/*
In the C# code, the int target is accessible inside the
BinarySearch method even though it's not passed as a parameter
because of variable scope.

In C#, nested functions (like the BinarySearch method in your
example) have access to variables declared in their enclosing
method (SortedFrequency).
*/

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static int SortedFrequency(int[] arr, int target)
        {
            // Helper function for binary search
            int BinarySearch(int left, int right)
            {
                if (left > right) return -1; // Target not found

                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    // Check left and right sides for occurrences
                    int leftCount = 0;
                    int rightCount = 0;

                    // Count occurrences to the left (including mid)
                    for (int i = mid - 1; i >= left && arr[i] == target; i--)
                    {
                        leftCount++;
                    }

                    // Count occurrences to the right (including mid)
                    for (int i = mid + 1; i <= right && arr[i] == target; i++)
                    {
                        rightCount++;
                    }

                    return leftCount + rightCount + 1; // Add mid occurrence
                }
                else if (arr[mid] < target)
                {
                    return BinarySearch(mid + 1, right);
                }
                else
                {
                    return BinarySearch(left, mid - 1);
                }
            }

            return BinarySearch(0, arr.Length - 1);
        }
    }
}

/*
SortedFrequency(arr: [1, 1, 2, 2, 2, 2, 3], target: 2)
  |
  |--> binarySearch(left: 0, right: 6)
          |
          |--> mid = (0 + 6) / 2 = 3
          |
          |--> arr[mid] = arr[3] = 2 (found target at mid)
                |
                |--> Count occurrences left of mid
                |        |
                |        |--> leftCount = 1 (arr[2] = 2)
                |
                |--> Count occurrences right of mid
                |        |
                |        |--> rightCount = 2 (arr[4] = 2, arr[5] = 2)
                |
                |--> Return leftCount + rightCount + 1 = 1 + 2 + 1 = 4
  |
  |--> Return 4 (final result)
*/