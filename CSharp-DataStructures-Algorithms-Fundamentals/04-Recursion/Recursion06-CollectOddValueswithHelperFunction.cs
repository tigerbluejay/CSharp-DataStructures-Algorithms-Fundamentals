using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class Recursion
    {
        // The outer function
        public static List<int> CollectOddValuesH(List<int> arr)
        {
            List<int> result = new List<int>();

            // The inner recursive helper function
            void Helper(List<int> helperInput)
            {
                if (helperInput.Count == 0) { return; }
                if (helperInput[0] % 2 != 0) { result.Add(helperInput[0]); }
                Helper(helperInput.GetRange(1, helperInput.Count - 1)); // recursive call
            }

            // Call the helper function
            Helper(arr);
            return result;
        }

    }
}

/*
CollectOddValues([1, 2, 3, 4, 5, 6, 7, 8, 9])
|-- Helper([1, 2, 3, 4, 5, 6, 7, 8, 9]) -> result = []
|    |-- helperInput[0] = 1 (odd) -> result = [1]

|-- Helper([1, 2, 3, 4, 5, 6, 7, 8, 9]) -> result = [1]
|    |-- helperInput[0] = 1 (odd) -> result = [1]
|    |-- Call Helper([2, 3, 4, 5, 6, 7, 8, 9])
|-- Helper([2, 3, 4, 5, 6, 7, 8, 9]) -> result = [1]
|    |-- helperInput[0] = 2 (even) -> result = [1]
|    |-- Call Helper([3, 4, 5, 6, 7, 8, 9])
|-- Helper([3, 4, 5, 6, 7, 8, 9]) -> result = [1]
|    |-- helperInput[0] = 3 (odd) -> result = [1, 3]

|    |-- Call Helper([4, 5, 6, 7, 8, 9])
|-- Helper([4, 5, 6, 7, 8, 9]) -> result = [1, 3]
|    |-- helperInput[0] = 4 (even) -> result = [1, 3]
|    |-- Call Helper([5, 6, 7, 8, 9])
|-- Helper([5, 6, 7, 8, 9]) -> result = [1, 3]
|    |-- helperInput[0] = 5 (odd) -> result = [1, 3, 5]

|    |-- Call Helper([6, 7, 8, 9])
|-- Helper([6, 7, 8, 9]) -> result = [1, 3, 5]
|    |-- helperInput[0] = 6 (even) -> result = [1, 3, 5]
|    |-- Call Helper([7, 8, 9])
|-- Helper([7, 8, 9]) -> result = [1, 3, 5]
|    |-- helperInput[0] = 7 (odd) -> result = [1, 3, 5, 7]

|    |-- Call Helper([8, 9])
|-- Helper([8, 9]) -> result = [1, 3, 5, 7]
|    |-- helperInput[0] = 8 (even) -> result = [1, 3, 5, 7]
|    |-- Call Helper([9])
|-- Helper([9]) -> result = [1, 3, 5, 7]
|    |-- helperInput[0] = 9 (odd) -> result = [1, 3, 5, 7, 9]

|    |-- Call Helper([]) // empty list
|-- Helper([]) -> result = [1, 3, 5, 7, 9]
|    |-- Base case: returns (nothing)
*/