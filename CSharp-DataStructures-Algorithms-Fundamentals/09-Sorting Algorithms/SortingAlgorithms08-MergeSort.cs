using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static List<int> MergeSort(List<int> arr)
        {
            if (arr.Count <= 1)
                return arr;

            int mid = arr.Count / 2;
            var left = MergeSort(arr.GetRange(0, mid));
            var right = MergeSort(arr.GetRange(mid, arr.Count - mid));

            Console.WriteLine(string.Join(", ", arr));
            return Merge(left, right);
        }
    }
}

/*
mergeSort([10, 24, 76, 73, 15, 20, 3, 19])


  mergeSort([10, 24, 76, 73])
    mergeSort([10, 24])
      mergeSort([10])
      mergeSort([24])
      merge([10], [24]) = [10, 24]
    mergeSort([76, 73])
      mergeSort([76])
      mergeSort([73])
      merge([76], [73]) = [73, 76]
    merge([10, 24], [73, 76]) = [10, 24, 73, 76]


  mergeSort([15, 20, 3, 19])
    mergeSort([15, 20])
      mergeSort([15])
      mergeSort([20])
      merge([15], [20]) = [15, 20]
    mergeSort([3, 19])
      mergeSort([3])
      mergeSort([19])
      merge([3], [19]) = [3, 19]

    merge([15, 20], [3, 19]) = [3, 15, 19, 20]

  merge([10, 24, 73, 76], [3, 15, 19, 20]) = [3, 10, 15, 19, 20, 24, 73, 76]
*/