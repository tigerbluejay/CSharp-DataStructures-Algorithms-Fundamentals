
namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    {
        public static bool SameFrequency(int num1, int num2)
        {
            // Convert numbers to strings and split into digits
            var num1Str = num1.ToString();
            var num2Str = num2.ToString();

            // Check if lengths are equal 
            // (different lengths imply different frequencies)
            if (num1Str.Length != num2Str.Length) return false;

            // Create frequency dictionaries for each number
            var num1Freq = new Dictionary<char, int>();
            var num2Freq = new Dictionary<char, int>();

            // Count occurrences of each digit in both numbers
            foreach (var digit in num1Str)
            {
                if (!num1Freq.ContainsKey(digit))
                    num1Freq[digit] = 0;
                num1Freq[digit]++;
            }

            foreach (var digit in num2Str)
            {
                if (!num2Freq.ContainsKey(digit))
                    num2Freq[digit] = 0;
                num2Freq[digit]++;
            }

            // Compare frequencies directly
            foreach (var kvp in num1Freq)
            {
                if (!num2Freq.ContainsKey(kvp.Key) || num2Freq[kvp.Key] != kvp.Value)
                    return false;
            }

            return true;
        }

    }
}

/*
Frequency Counter - sameFrequency

Write a function called sameFrequency. 
Given two positive integers, find out if the two 
numbers have the same frequency of digits.

Your solution MUST have the following complexities:

Time: O(N)

Sample Input:

SameFrequency(182,281) // true
SameFrequency(34,14) // false
SameFrequency(3589578, 5879385) // true
SameFrequency(22,222) // false
*/