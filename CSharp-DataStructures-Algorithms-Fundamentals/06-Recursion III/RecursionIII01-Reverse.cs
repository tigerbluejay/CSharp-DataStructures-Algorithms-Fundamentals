using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIII
    {

        public static string Reverse(string str)
        {
            if (str.Length <= 1) return str;
            return Reverse(str.Substring(1)) + str[0];
        }
    }
}

/*
Reverse

Write a recursive function called reverse which accepts a string and 
returns a new string in reverse.
*/
