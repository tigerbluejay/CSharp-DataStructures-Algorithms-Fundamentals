namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;

    public partial class MultiplePointers
    {
        public static bool AveragePair(int[] arr, double num)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                double avg = (arr[start] + arr[end]) / 2.0;

                if (avg == num)
                    return true;

                // If the tested average is less than the target average,
                // move the start pointer up
                if (avg < num)
                    start++;
                // Otherwise, move the end pointer down
                else
                    end--;
            }

            return false;
        }

    }
}

/*
Multiple Pointers - averagePair

Write a function called averagePair. 
Given a sorted array of integers and a target average, 
determine if there is a pair of values in the array where 
the average of the pair equals the target average. 

There may be more than one pair that matches the average target.

Bonus Constraints:
Time: O(N)
Space: O(1)

*/