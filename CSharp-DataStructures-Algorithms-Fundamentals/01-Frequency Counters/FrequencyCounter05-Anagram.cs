namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    { 

        public static bool ValidAnagram(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }

            // Create a dictionary to store the frequency of characters in
            // the first string
            Dictionary<char, int> lookup = new Dictionary<char, int>();

            // Populate the frequency counter for the first string
            foreach (char letter in first)
            {
                if (lookup.ContainsKey(letter))
                {
                    lookup[letter]++;
                }
                else
                {
                    // The line lookup[letter] = 1; is indeed responsible for
                    // adding the character as a key to the dictionary (if it
                    // doesn't already exist) and initializing its value to 1.
                    lookup[letter] = 1;
                }
            }

            // Debugging: Print the lookup table (optional)
            foreach (var pair in lookup)
            {
                Console.WriteLine($"lookup[{pair.Key}] = {pair.Value}");
            }

            // Check the second string against the frequency counter
            foreach (char letter in second)
            {
                if (!lookup.ContainsKey(letter) || lookup[letter] == 0)
                {
                    return false;
                }
                else
                {
                    lookup[letter]--;
                }
            }

            return true;
        }
    }
}

