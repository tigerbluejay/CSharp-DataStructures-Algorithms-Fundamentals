namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class MultiplePointers
    {
        public static int CountUniqueValues(int[] arr)
        {
            if (arr.Length == 0) return 0;

            // Pointer for tracking unique values
            int i = 0; 


            for (int j = 1; j < arr.Length; j++)
            {
                // When two pointers point to different elements
                // compare the 0th element with the 1st and so on
                if (arr[i] != arr[j])
                {
                    i++; // Increment the first pointer - counting the unique values
                    // Assign the value of the second pointer to the first***
                    arr[i] = arr[j]; 
                }
            }

            // i is counting the unique values, but
            // j is looping through all the values to check.
            return i + 1; // Return the count of unique values
        }
    }
}

// *** This line ensures that all unique values in the array are grouped together
// at the beginning of the array, in sequential order.
// While the main goal of the algorithm is to count the unique values,
// this step "overwrites" duplicates in the array as it progresses.
// Essentially, it moves the unique values to the left side of the array
// (up to index i).