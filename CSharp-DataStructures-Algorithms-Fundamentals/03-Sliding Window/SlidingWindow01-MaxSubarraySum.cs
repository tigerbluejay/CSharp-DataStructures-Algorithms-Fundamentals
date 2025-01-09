namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;

    public partial class SlidingWindow
    {
        public static int? MaxSubarraySum(int[] arr, int num)
        {
            // Edge case: make sure the array is not longer than the number of digits
            // we are trying to sum
            if (num > arr.Length)
            {
                return null;
            }

            int max = int.MinValue;

            for (int i = 0; i < arr.Length - num + 1; i++)
            {
                int temp = 0;
                for (int j = 0; j < num; j++)
                {
                    temp += arr[i + j];
                }
                if (temp > max)
                {
                    max = temp;
                }
            }
            return max;
        }

/*
Input:new int[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 }, 3;

i: 0, j: 0, arr[i+j]: 2, running sum: 2
i: 0, j: 1, arr[i+j]: 6, running sum: 8
i: 0, j: 2, arr[i+j]: 9, running sum: 17, temp sum: 17
i: 1, j: 0, arr[i+j]: 6, running sum: 6
i: 1, j: 1, arr[i+j]: 9, running sum: 15
i: 1, j: 2, arr[i+j]: 2, running sum: 17, temp sum: 17
i: 2, j: 0, arr[i+j]: 9, running sum: 9
i: 2, j: 1, arr[i+j]: 2, running sum: 11
i: 2, j: 2, arr[i+j]: 1, running sum: 12, temp sum: 12
i: 3, j: 0, arr[i+j]: 2, running sum: 2
i: 3, j: 1, arr[i+j]: 1, running sum: 3
i: 3, j: 2, arr[i+j]: 8, running sum: 11, temp sum: 11
i: 4, j: 0, arr[i+j]: 1, running sum: 1
i: 4, j: 1, arr[i+j]: 8, running sum: 9
i: 4, j: 2, arr[i+j]: 5, running sum: 14, temp sum: 14
i: 5, j: 0, arr[i+j]: 8, running sum: 8
i: 5, j: 1, arr[i+j]: 5, running sum: 13
i: 5, j: 2, arr[i+j]: 6, running sum: 19, temp sum: 19
i: 6, j: 0, arr[i+j]: 5, running sum: 5
i: 6, j: 1, arr[i+j]: 6, running sum: 11
i: 6, j: 2, arr[i+j]: 3, running sum: 14, temp sum: 14
 */

        public static int? MaxSubarraySum2(int[] arr, int num)
        {
            if (arr.Length < num)
            {
                return null;
            }

            int maxSum = 0;
            int tempSum = 0;

            // Calculate the initial sum of the first window
            for (int i = 0; i < num; i++)
            {
                maxSum += arr[i];
            }

            tempSum = maxSum;

            // Slide the window across the array
            for (int i = num; i < arr.Length; i++)
            {
                // Adjust tempSum by subtracting the first digit
                // of the previous window and adding the next digit in the array
                tempSum = tempSum - arr[i - num] + arr[i]; // take one out, add new one in
                maxSum = Math.Max(maxSum, tempSum);
            }

            return maxSum;
        }
    }
}

/*
Input:new int[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 }, 3;

i: 3, outgoing: 2, incoming: 2, temp_sum: 17, max_sum: 17
i: 4, outgoing: 6, incoming: 1, temp_sum: 12, max_sum: 17
i: 5, outgoing: 9, incoming: 8, temp_sum: 11, max_sum: 17
i: 6, outgoing: 2, incoming: 5, temp_sum: 14, max_sum: 17
i: 7, outgoing: 1, incoming: 6, temp_sum: 19, max_sum: 19
i: 8, outgoing: 8, incoming: 3, temp_sum: 14, max_sum: 19

Explanation of Columns:
i: Current index of the outer loop during the sliding window.
outgoing: The value removed from the sliding window (arr[i - num]).
incoming: The new value added to the sliding window (arr[i]).
temp_sum: The current sum of the sliding window after adjustments.
max_sum: The maximum sum encountered so far.
 */