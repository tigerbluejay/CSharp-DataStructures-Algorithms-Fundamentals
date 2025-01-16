using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionII
    {
        public static int ProductOfArray(int[] arr)
        {
            if (arr.Length == 0) return 1;

            // Recursively call the function on the rest of the array
            int[] rest = new int[arr.Length - 1];

            // arr is source array, 1 is the position in arr where copying begins
            // rest is the destination array, 0 is the position in rest where copying begins
            // arr.Length - 1 is the number of elements to copy, so all the elements in arr (starting in position 1)
            Array.Copy(arr, 1, rest, 0, arr.Length - 1);

            return arr[0] * ProductOfArray(rest);
        }

    }
}
/*
ProductOfArray({1, 2, 3, 4, 5})
    |
    1 * ProductOfArray({2, 3, 4, 5})
                      |
                      2 * ProductOfArray({3, 4, 5})
                                |
                                3 * ProductOfArray({4, 5})
                                          |
                                          4 * ProductOfArray({5})
                                                    |
                                                    5 * ProductOfArray({})
                                                              |
                                                              1 (base case)

*/


/* 
ProductOfArray

Write a function called productOfArray which takes in an array of 
numbers and returns the product of them all.
*/