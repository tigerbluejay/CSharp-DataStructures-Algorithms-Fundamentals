namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    {
        // Frequency Counter Approach (O(n) Time, O(n) Space)
        public static bool AreThereDuplicates(params object[] args)
        {
            // Create a frequency counter dictionary
            var freqCounter = new Dictionary<object, int>();

            foreach (var arg in args)
            {
                // Check if the argument already exists in the counter
                if (freqCounter.ContainsKey(arg))
                {
                    return true; // Duplicate found
                }

                // Add the argument to the counter
                freqCounter[arg] = 1;
            }

            // No duplicates found
            return false;
        }

        // Frequency Counter Solution - (O(n log n) Time, O(1) Space):
        public static bool AreThereDuplicates_FC(params object[] args)
        {
            // Sort the arguments in-place
            Array.Sort(args);

            // Check for consecutive duplicates
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i].Equals(args[i - 1]))
                {
                    return true;
                }
            }

            // No duplicates found
            return false;
        }


        //  Multiple Pointers Approach(O(n log n) Time, O(1) Space)
        public static bool AreThereDuplicatesMP(params object[] args)
        {
            // Sort the arguments to bring duplicates together
            Array.Sort(args);

            // Check for consecutive duplicates
            for (int i = 0; i < args.Length - 1; i++)
            {
                if (args[i].Equals(args[i + 1]))
                {
                    return true; // Duplicate found
                }
            }

            // No duplicates found
            return false;
        }


        // Multiple Pointers Solution - (O(n log n) Time, O(1) Space):
        public static bool AreThereDuplicatesMP2(params object[] args)
        {
            // Convert the arguments to a Set (removes duplicates)
            var seen = new HashSet<object>(args);

            // If the size of the set is different from the length of the original args, there are duplicates
            return seen.Count != args.Length;
        }

    }
}

/*
Frequency Counter / Multiple Pointers - areThereDuplicates

Implement a function called, areThereDuplicates 

which accepts a variable number of arguments, and checks 
whether there are any duplicates among the arguments passed in.  

You can solve this using
the frequency counter pattern OR
the multiple pointers pattern.

*/