using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        public static List<int> Merge(List<int> arr1, List<int> arr2)
        {
            List<int> results = new List<int>();
            int i = 0, j = 0;

            while (i < arr1.Count && j < arr2.Count)
            {
                if (arr2[j] > arr1[i])
                {
                    results.Add(arr1[i]);
                    i++;
                }
                else
                {
                    results.Add(arr2[j]);
                    j++;
                }
            }

            while (i < arr1.Count)
            {
                results.Add(arr1[i]);
                i++;
            }

            while (j < arr2.Count)
            {
              results.Add(arr2[j]);
              j++;
            }

            return results;
        }

    }
}