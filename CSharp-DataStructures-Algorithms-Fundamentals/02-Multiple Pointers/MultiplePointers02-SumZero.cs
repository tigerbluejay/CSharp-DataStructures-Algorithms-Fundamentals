namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;

    public static partial class MultiplePointers
    {
        public static int[] SumZeroNaive(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == 0)
                    {
                        return new int[] { arr[i], arr[j] };
                    }
                }
            }
            return null;
        }

/*
MULTIPLE POINTERS - NAIVE SOLUTION

Write a function called sumZero which accepts a sorted array of integers.
This function should find the first pair where the sum is 0.
Return an array that includes both values that sum to zero or
null if a pair does not exist
*/



        // Since the array is sorted in increasing order, the elements are
        // arranged from the smallest to the largest.
        // In order to make the sum smaller, you need to decrease the larger number.
        // Since the array is sorted, the right pointer points to the largest number,
        // and by moving it left (right--), you are reducing the larger number.

        // By decreasing the right pointer (when the sum is greater than 0), you are
        // effectively trying a smaller number for the second element, which might
        // lead to a sum closer to zero.

        public static int[] NewSumZero(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];
                if (sum == 0)
                {
                    return new int[] { arr[left], arr[right] };
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return null;
        }

        // Time complexity O(N)
        // Space complexity O(1)
    }

}

