namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    using System;
    using System.Collections.Generic;

    public static partial class FrequencyCounters
    {
        public static bool ConstructNote(string message, string letters)
        {
            if (message.Length > letters.Length)
            {
                return false;
            }

            // Count the frequency of each letter in the letters string
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            foreach (char letter in letters)
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount[letter] = 1;
                }
            }

            // Check if the message can be constructed using the available letters
            foreach (char ch in message)
            {
                if (!letterCount.ContainsKey(ch) || letterCount[ch] == 0)
                {
                    return false;
                }
                else
                {
                    letterCount[ch]--;
                }
            }

            return true;
        }

    }
}