using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIII
    {

        public static bool SomeRecursive(int[] array, Func<int, bool> callback)
        {
            if (array.Length == 0) return false;
            if (callback(array[0])) return true;

            // Create a new array excluding the first element
            int[] rest = new int[array.Length - 1];
            Array.Copy(array, 1, rest, 0, array.Length - 1);

            return SomeRecursive(rest, callback);
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}


/*
SomeRecursive([1, 3, 5, 8, 10], IsOdd)
│   IsOdd(1) -> true
│   Return true

The first call to SomeRecursive is made with the array [1, 3, 5, 8, 10]
and IsOdd as the callback.
*/

/*
SomeRecursive([10, 8, 5, 3, 1], IsOdd)
│   IsOdd(10) -> false
│   Recurse with [8, 5, 3, 1]
│
├── SomeRecursive([8, 5, 3, 1], IsOdd)
│   │   IsOdd(8) -> false
│   │   Recurse with [5, 3, 1]
│   │
├───┬── SomeRecursive([5, 3, 1], IsOdd)
│   │   │   IsOdd(5) -> true
│   │   │   Return true

*/



/*
SomeRecursive

Write a recursive function called someRecursive which accepts an 
array and a callback. The function returns true if a single value in 
the array returns true when passed to the callback. Otherwise it 
returns false.
*/