using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIII
    {

        public static bool IsPalindrome(string str)
        {
            if (str.Length == 1) return true;
            if (str.Length == 2) return str[0] == str[1];
            if (str[0] == str[^1]) // Use the `^` operator to access the last character
                return IsPalindrome(str.Substring(1, str.Length - 2)); // Exclude the first and last characters
            return false;
        }
    }
}

/*
IsPalindrome

Write a recursive function called isPalindrome which returns true 
if the string passed to it is a palindrome (reads the same forward 
and backward). Otherwise it returns false.

*/