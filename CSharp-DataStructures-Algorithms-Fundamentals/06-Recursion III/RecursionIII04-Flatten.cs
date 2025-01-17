using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIII
    {
        public static List<int> Flatten(object[] oldArray)
        {
            var newArray = new List<int>();

            foreach (var item in oldArray)
            {
                if (item is object[] nestedArray) // Check if the item is an array
                {
                    // Recursively flatten the nested array
                    newArray.AddRange(Flatten(nestedArray));
                }
                else if (item is int number) // If it's an integer, add it to the result
                {
                    newArray.Add(number);
                }
            }

            return newArray;
        }
    }
}


/*
The AddRange function in C# is a method available in the List<T> class.
It allows you to add all the elements of a collection (like another list,
array, or any enumerable object) to the end of an existing List<T>.
*/

/*
Tree Diagram of Recursive Calls:
lua
Copy
Edit
Flatten([1, [2, 3], 4, [5, [6, 7]]])
|
|-- Add 1
|
|-- Flatten([2, 3])
|   |
|   |-- Add 2
|   |-- Add 3
|
|-- Add 4
|
|-- Flatten([5, [6, 7]])
|   |
|   |-- Add 5
|   |
|   |-- Flatten([6, 7])
|       |
|       |-- Add 6
|       |-- Add 7
|
|-- Final Result: [1, 2, 3, 4, 5, 6, 7]
*/


/*
We could rewrite Flatten with Linq's Select Many like this:

    static IEnumerable<int> Flatten(IEnumerable<object> array)
    {
        return array.SelectMany(item =>
            item is IEnumerable<object> nestedArray 
                ? Flatten(nestedArray) // Recursively flatten nested arrays
                : new[] { (int)item }); // Wrap single integers in an array
    }
*/

/*
Flatten

Write a recursive function called flatten which accepts an array of arrays 
and returns a new array with all values flattened.
*/
