using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        // The method GetDigit extracts a specific digit from a given integer
        // num at the position i
        public static int GetDigit(int num, int i)
        {
            return (int)(Math.Floor(Math.Abs(num) / Math.Pow(10, i)) % 10);
        }

        // Function to count the number of digits in a number
        public static int DigitCount(int num)
        {
            if (num == 0) return 1;
            return (int)(Math.Floor(Math.Log10(Math.Abs(num))) + 1);
        }

        /*
        In essence, this code snippet calculates the number of digits required
        to represent the absolute value of the input number num.

            Here's a breakdown of how it works for different inputs:

            Input: 123:

            Math.abs(123) = 123
            Math.log10(123) ≈ 2.096
            Math.floor(2.096) = 2
            Therefore, the number of digits is 2 + 1 = 3
        */


        // Function to find the maximum number of digits in an array
        public static int MostDigits(int[] nums)
        {
            int maxDigits = 0;
            foreach (int num in nums)
            {
                maxDigits = Math.Max(maxDigits, DigitCount(num));
            }
            return maxDigits;
        }
    }
}


