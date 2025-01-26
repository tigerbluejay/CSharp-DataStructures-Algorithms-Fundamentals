using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class SearchingAlgorithms
    {

        public static int NaiveSearchSS(string longStr, string shortStr)
        {
            int count = 0;

            for (int i = 0; i < longStr.Length; i++)
            {
                for (int j = 0; j < shortStr.Length; j++)
                {
                    if (i + j >= longStr.Length || shortStr[j] != longStr[i + j])
                    {
                        break;
                    }
                    if (j == shortStr.Length - 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

/*
Start Naive Search ("lorie loled", "lol")

i = 0
  j = 0 -> 'l' == 'l' (match)
  j = 1 -> 'o' == 'o' (match)
  j = 2 -> 'r' != 'l' (break)

i = 1
  j = 0 -> 'o' != 'l' (break)

i = 2
  j = 0 -> 'r' != 'l' (break)

i = 3
  j = 0 -> 'i' != 'l' (break)

i = 4
  j = 0 -> 'e' != 'l' (break)

i = 5
  j = 0 -> ' ' != 'l' (break)

i = 6
  j = 0 -> 'l' == 'l' (match)
  j = 1 -> 'o' == 'o' (match)
  j = 2 -> 'l' == 'l' (match)
  - Match Found! Increment count to 1

i = 7
  j = 0 -> 'o' != 'l' (break)

i = 8
  j = 0 -> 'l' != 'l' (break)

i = 9
  j = 0 -> 'e' != 'l' (break)

i = 10
  j = 0 -> 'd' != 'l' (break)

End Naive Search
Result: Count = 1

*/
