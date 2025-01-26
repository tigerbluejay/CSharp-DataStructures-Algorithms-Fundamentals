using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static void BubbleSort(int[] arr)
        {
            for (int i = arr.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Console.WriteLine($"Array: {string.Join(", ", arr)}, " +
                        $"Comparing: {arr[j]} and {arr[j + 1]}");

                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}

/*
Why Isn't Bubble Sort a Multiple Pointers Case?
Bubble Sort doesn't use multiple pointers.
Instead:

It uses a nested loop structure to iterate through the array repeatedly.
The inner loop compares adjacent elements and swaps them if necessary,
moving larger elements to the end of the array step by step.
The "pointers" (or indices) used in Bubble Sort are not working
independently toward a single goal, but rather one (j) iterates
sequentially through the array while the other (i) controls the
shrinking range of unsorted elements.
This is more of a comparison-based sorting algorithm than an
application of the multiple pointers pattern.
*/