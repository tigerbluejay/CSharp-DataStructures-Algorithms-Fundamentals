namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;

    public partial class SlidingWindow
    {

        public static int? MaxSubarraySum3(int[] arr, int num)
        {
            // Return null if the array length is smaller than the required subarray length
            if (arr.Length < num)
            {
                return null;
            }

            int total = 0;

            // Calculate the initial sum of the first window
            for (int i = 0; i < num; i++)
            {
                total += arr[i];
            }

            int currentTotal = total;

            // Slide the window across the array
            for (int i = num; i < arr.Length; i++)
            {
                // Adjust the current total by adding the incoming element
                // and removing the outgoing element from the window
                currentTotal += arr[i] - arr[i - num];
                total = Math.Max(total, currentTotal);
            }

            return total;
        }

    }
}