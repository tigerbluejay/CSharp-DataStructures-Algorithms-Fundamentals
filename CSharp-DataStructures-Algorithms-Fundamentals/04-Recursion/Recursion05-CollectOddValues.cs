using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class Recursion
    {
        public static List<int> CollectOddValues(List<int> arr)
        {
            List<int> newArr = new List<int>();

            if (arr.Count == 0)
            {
                return newArr;
            }

            if (arr[0] % 2 != 0)
            {
                newArr.Add(arr[0]);
            }

            // The AddRange method in C# is used to add multiple elements from an
            // IEnumerable (such as a list or array) to a List<T> in one operation.
            // It allows you to append a collection of elements to an existing list.
            newArr.AddRange(CollectOddValues(arr.Skip(1).ToList()));
            return newArr;
        }
    }
}

/*
collectOddValues([1, 2, 3, 4, 5])
├── Include 1(odd): newArr = [1]
└── collectOddValues([2, 3, 4, 5])
    ├── Skip 2(even): newArr = []
    └── collectOddValues([3, 4, 5])
        ├── Include 3(odd): newArr = [3]
        └── collectOddValues([4, 5])
            ├── Skip 4(even): newArr = []
            └── collectOddValues([5])
                ├── Include 5(odd): newArr = [5]
                └── collectOddValues([])
                    └── Base case: newArr = []
*/