using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIV
    {
        public static Dictionary<string, object> StringifyNumbers(Dictionary<string, object> obj)
        {
            var newObj = new Dictionary<string, object>();

            foreach (var kvp in obj)
            {
                // check if it's a number
                if (kvp.Value is int || kvp.Value is double)  
                {
                    newObj[kvp.Key] = kvp.Value.ToString();
                }
                // if it's a nested object (dictionary)
                else if (kvp.Value is Dictionary<string, object> nestedObj)  
                {
                    // recurse into the nested object
                    newObj[kvp.Key] = StringifyNumbers(nestedObj);  
                }
                else
                {
                    newObj[kvp.Key] = kvp.Value;
                }
            }

            return newObj;
        }
    }
}

/*
kvp.Value is Dictionary<string, object> nestedObj:
This is a combination of type checking and variable assignment in one line.
Essentially, it checks whether kvp.Value is of type Dictionary<string, object>.
If it is, it assigns the value to the variable nestedObj. This approach is part
of pattern matching.

Before C# 7.0 (or if you're avoiding pattern matching for any reason), you would
typically do the check and cast separately, like so:

else if (kvp.Value is object)
{
    var nestedObj = (Dictionary<string, object>)kvp.Value;
    // Recurse into the nested object
    newObj[kvp.Key] = StringifyNumbers(nestedObj);  
}
*/

/*
StringifyNumbers

Write a function called StringifyNumbers
which takes in a dictionary and finds all of the values which
are numbers and converts them to strings.
Recursion would be a great way to solve this!

*/