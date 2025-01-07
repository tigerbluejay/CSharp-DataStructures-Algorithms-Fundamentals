namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    {
        public static bool Same(int[] arr1, List<int> arr2)
        {
            if (arr1.Length != arr2.Count)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                int squaredValue = arr1[i] * arr1[i];
                int correctIndex = arr2.IndexOf(squaredValue);

                //  the IndexOf method in C# returns -1 if the element is
                //  not found in the list or array.
                if (correctIndex == -1)
                {
                    return false;
                }

                // This line is primarily for debugging. It allows the developer
                // to see the state of the arr2 list after each iteration of the loop.
                Console.WriteLine(string.Join(", ", arr2));

                // This step ensures that each squared value in arr2 is used only once,
                // even if there are duplicates in arr1. Without this removal,
                // duplicate values in arr1 could incorrectly match the same squared
                // value in arr2 multiple times.
                arr2.RemoveAt(correctIndex);
            }

            return true;
        }
    }
}

/*
Write a function called same.
The function accepts two arrays (in this C# translation an array and a list)
The function should return true if every value in the array
has its corresponding value squared in the second array (list)
(not necessarily in the same order in both arrays)
The frecuency of values should be the same.
*/