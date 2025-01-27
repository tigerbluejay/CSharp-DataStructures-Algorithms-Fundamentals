using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SortingAlgorithms
    {
        // Radix Sort Implementation
        public static int[] RadixSort(int[] nums)
        {
            int maxDigitCount = MostDigits(nums);

            // Loop through each digit place (k)
            for (int k = 0; k < maxDigitCount; k++)
            {
                // Create buckets for digits 0-9
                List<int>[] digitBuckets = new List<int>[10];
                for (int i = 0; i < 10; i++)
                {
                    digitBuckets[i] = new List<int>();
                }

                // Place each number in the appropriate bucket based
                // on the current digit
                foreach (int num in nums)
                {
                    int digit = GetDigit(num, k);
                    digitBuckets[digit].Add(num);
                }

                // Rebuild nums by flattening all buckets
                nums = digitBuckets.SelectMany(bucket => bucket).ToArray();
            }

            return nums;
        }
    }
}

/*
Initial Array: 23, 345, 5467, 12, 2345, 9852

Pass 1 (Sorting by Ones Place - k = 0):
Bucket 0: 
Bucket 1: 
Bucket 2: 12, 9852
Bucket 3: 23
Bucket 4: 
Bucket 5: 345, 2345
Bucket 6: 
Bucket 7: 5467
Bucket 8: 
Bucket 9: 
Flattened Array: 12, 9852, 23, 345, 2345, 5467

Pass 2 (Sorting by Tens Place - k = 1):
Bucket 0: 
Bucket 1: 12
Bucket 2: 23
Bucket 3: 
Bucket 4: 345, 2345
Bucket 5: 9852
Bucket 6: 5467
Bucket 7: 
Bucket 8: 
Bucket 9: 
Flattened Array: 12, 23, 345, 2345, 9852, 5467

Pass 3 (Sorting by Hundreds Place - k = 2):
Bucket 0: 12, 23
Bucket 1: 
Bucket 2: 
Bucket 3: 345, 2345
Bucket 4: 5467
Bucket 5: 
Bucket 6: 
Bucket 7: 
Bucket 8: 9852
Bucket 9: 
Flattened Array: 12, 23, 345, 2345, 5467, 9852

Pass 4 (Sorting by Thousands Place - k = 3):
Bucket 0: 12, 23, 345
Bucket 1: 
Bucket 2: 2345
Bucket 3: 
Bucket 4: 
Bucket 5: 5467
Bucket 6: 
Bucket 7: 
Bucket 8: 
Bucket 9: 9852
Flattened Array: 12, 23, 345, 2345, 5467, 9852

Final Sorted Array: 12, 23, 345, 2345, 5467, 9852
*/