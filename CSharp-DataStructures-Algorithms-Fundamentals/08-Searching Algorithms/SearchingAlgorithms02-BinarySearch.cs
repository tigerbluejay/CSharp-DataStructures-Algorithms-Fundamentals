using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SearchingAlgorithms
    {

        // original solution
        public static int BinarySearch(int[] arr, int elem)
        {
            // start end and middle are all pointers
            int start = 0;
            int end = arr.Length - 1;
            int middle = (start + end) / 2;

            while (arr[middle] != elem && start <= end)
            {
                if (elem < arr[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
                middle = (start + end) / 2;
            }

            if (arr[middle] == elem)
            {
                return middle;
            }
            return -1;
        }


        // refactored solution
        public static int BinarySearchR(int[] arr, int elem)
        {
            int start = 0;
            int end = arr.Length - 1;
            int middle = (start + end) / 2;

            while (arr[middle] != elem && start <= end)
            {
                if (elem < arr[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
                middle = (start + end) / 2;
            }

            return arr[middle] == elem ? middle : -1;
        }
    }
}