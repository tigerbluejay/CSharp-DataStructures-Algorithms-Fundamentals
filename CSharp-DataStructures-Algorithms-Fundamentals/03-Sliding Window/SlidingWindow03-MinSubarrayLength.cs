namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;

    public partial class SlidingWindow
    {
        public static int MinSubArrayLen(int[] nums, int sum)
        {
            int total = 0;
            int start = 0;
            int end = 0;
            int minLen = int.MaxValue;

            while (start < nums.Length)
            {
                // Expand the window by moving the `end` pointer
                if (total < sum && end < nums.Length)
                {
                    total += nums[end];
                    end++;
                }
                // Shrink the window by moving the `start` pointer
                else if (total >= sum)
                {
                    minLen = Math.Min(minLen, end - start);
                    total -= nums[start];
                    start++;
                }
                // Exit the loop if `end` has reached the end and total is
                // less than `sum`
                else
                {
                    break;
                }
            }

            return minLen == int.MaxValue ? 0 : minLen;
        }

    }
}

/*
Design an algorithm to find the minimal length of a contiguous subarray with a
sum greater than or equal to a given value, use the sliding window technique.
*/
/*
Input: new int[] { 2, 3, 1, 2, 4, 3 }, 7 // Ouput=2

Iteration 1: start = 0, end = 1, total = 2
Iteration 2: start = 0, end = 2, total = 5
Iteration 3: start = 0, end = 3, total = 6
Iteration 4: start = 0, end = 4, total = 8
Iteration 5: start = 1, end = 4, total = 6
Iteration 6: start = 1, end = 5, total = 10
Iteration 7: start = 2, end = 5, total = 7
Iteration 8: start = 3, end = 5, total = 6

The while loop condition is start < nums.length.
Since start = 3 and nums.length = 6, the loop condition is still true.

However, inside the loop, the else condition (total < sum && end == nums.length)
will eventually trigger. At this point:

    total < sum (6 < 7).
    end == nums.length (end has reached the array boundary).

When this happens, the algorithm breaks out of the loop using the break statement,
ending the process.
 
 */