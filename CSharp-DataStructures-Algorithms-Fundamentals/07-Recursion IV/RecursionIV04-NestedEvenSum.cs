using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIV
    {

        public static int NestedEvenSum(Dictionary<string, object> obj, int sum = 0)
        {
            foreach (var key in obj.Keys)
            {
                if (obj[key] is Dictionary<string, object> nestedObj)
                {
                    sum += NestedEvenSum(nestedObj);
                }
                else if (obj[key] is int number && number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}

/*
NestedEvenSum

Write a recursive function called NestedEvenSum. 
Return the sum of all even numbers in an object which may contain 
nested objects.
*/