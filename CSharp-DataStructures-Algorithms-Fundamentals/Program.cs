using CSharp_DataStructures_Algorithms_Fundamentals._10_Singly_Linked_List;
using System;
using System.Collections.Generic;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    class Program
    {
        public static void Main()
        {
            ////////////////////////////////////////////////////////////
            ////////////// 01- FREQUENCY COUNTERS //////////////////////
            ////////////////////////////////////////////////////////////

            Console.WriteLine("Frequency Counters");
            Console.WriteLine();
            Console.WriteLine(FrequencyCounters.SameFrequency(182, 281)); // true
            Console.WriteLine(FrequencyCounters.SameFrequency(34, 14)); // false
            Console.WriteLine(FrequencyCounters.SameFrequency(3589578, 5879385)); // true
            Console.WriteLine(FrequencyCounters.SameFrequency(22, 222)); // false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicates(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicates(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicates('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicates_FC(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicates_FC(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicates_FC('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP2(1, 2, 3)); // false
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP2(1, 2, 2)); // true
            Console.WriteLine(FrequencyCounters.AreThereDuplicatesMP2('a', 'b', 'c', 'a')); // true
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.Same(new int[] { 1, 2, 3, 2 }, new List<int> { 9, 1, 4, 4 }));
            // Output: true or false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.SameRefactored(new int[] { 1, 2, 3, 2, 5 }, new int[] { 9, 1, 4, 4, 11 }));
            // Output: false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.ValidAnagram("anagrams", "nagaramm"));
            // Output: false
            Console.WriteLine();

            Console.WriteLine(FrequencyCounters.ConstructNote("aa", "abc"));          // Output: false
            Console.WriteLine(FrequencyCounters.ConstructNote("abc", "dcba"));        // Output: true
            Console.WriteLine(FrequencyCounters.ConstructNote("aabbcc", "bcabcaddff")); // Output: true

            Console.WriteLine(string.Join(", ",
                FrequencyCounters.FindAllDuplicates(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 })));
            // Output: 2, 3
            Console.WriteLine(string.Join(", ",
                FrequencyCounters.FindAllDuplicates(new int[] { 4, 3, 2, 1, 0 })));
            // Output: (empty)
            Console.WriteLine(string.Join(", ",
                FrequencyCounters.FindAllDuplicates(new int[] { 4, 3, 2, 1, 0, 1, 2, 3 })));
            // Output: 1, 2, 3

            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 6, 1, 4, 10, 2, 4 }, 2));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 8, 6, 2, 4, 1, 0, 2, 5, 13 }, 1));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 4, -2, 3, 10 }, -6));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 6, 1, 4, 10, 2, 4 }, 22));
            // Output: false
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { }, 0));
            // Output: false
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 5, 5 }, 0));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { -4, 4 }, -8));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { -4, 4 }, 8));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 1, 3, 4, 6 }, -2));
            // Output: true
            Console.WriteLine(FrequencyCounters.FindPair(new int[] { 0, 1, 3, 4, 6 }, -2));
            // Output: true

            ////////////////////////////////////////////////////////////
            ////////////// 02- MULTIPLE POINTERS ///////////////////////
            ////////////////////////////////////////////////////////////

            Console.WriteLine("Multiple Pointers");
            Console.WriteLine();

            Console.WriteLine(MultiplePointers.CountUniqueValues(new int[] { 1, 2, 2, 5, 7, 7, 99 }));
            // Output: 5

            Console.WriteLine(MultiplePointers.SumZeroNaive(new int[] { -4, -3, -2, -1, 0, 1, 2, 5 }));
            Console.WriteLine(MultiplePointers.NewSumZero(new int[] { -4, -3, -2, -1, 0, 1, 2, 3, 10 }));

            Console.WriteLine(MultiplePointers.IsSubsequenceIterative("abc", "ahbgdc")); // Output: true
            Console.WriteLine(MultiplePointers.IsSubsequenceRecursive("abc", "ahbgdc"));

            Console.WriteLine(MultiplePointers.AveragePair(new int[] { 1, 2, 3 }, 2.5)); // true
            Console.WriteLine(MultiplePointers.AveragePair(new int[] { 1, 3, 3, 5, 6, 7, 10, 12, 19 }, 8)); // true
            Console.WriteLine(MultiplePointers.AveragePair(new int[] { -1, 0, 3, 4, 5, 6 }, 4.1)); // false
            Console.WriteLine(MultiplePointers.AveragePair(new int[] { }, 4)); // false

            ////////////////////////////////////////////////////////////
            ////////////// 03- SLIDING WINDOW //////////////////////////
            ////////////////////////////////////////////////////////////

            Console.WriteLine(SlidingWindow.MaxSubarraySum(new int[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 }, 3));
            Console.WriteLine(SlidingWindow.MaxSubarraySum2(new int[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 }, 3));

            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 100, 200, 300, 400 }, 2)); // 700
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 1, 4, 2, 10, 23, 3, 1, 0, 20 }, 4)); // 39
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { -3, 4, 0, -2, 6, -1 }, 2)); // 5
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 3, -2, 7, -4, 1, -1, 4, -2, 1 }, 2)); // 5
            Console.WriteLine(SlidingWindow.MaxSubarraySum3(new int[] { 2, 3 }, 3)); // null

            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 2, 3, 1, 2, 4, 3 }, 7)); // 2
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 2, 1, 6, 5, 4 }, 9));    // 2
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 3, 1, 7, 11, 2, 9, 8, 21, 62, 33, 19 }, 52)); // 1
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 39));         // 3
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 55));         // 5
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 4, 3, 3, 8, 1, 2, 3 }, 11));                 // 2
            Console.WriteLine(SlidingWindow.MinSubArrayLen(new int[] { 1, 4, 16, 22, 5, 7, 8, 9, 10 }, 95));         // 0

            Console.WriteLine(SlidingWindow.FindLongestSubstring("rithmschool")); // Output: 7
            Console.WriteLine(SlidingWindow.FindLongestSubstring("thisisawesome")); // Output: 6
            Console.WriteLine(SlidingWindow.FindLongestSubstring("thecatinthehat")); // Output: 7
            Console.WriteLine(SlidingWindow.FindLongestSubstring("bbbbbbb")); // Output: 1
            Console.WriteLine(SlidingWindow.FindLongestSubstring("longestsubstring")); // Output: 8
            Console.WriteLine(SlidingWindow.FindLongestSubstring("thisishowwedoit")); // Output: 6

            ////////////////////////////////////////////////////////////
            /////////////////// 04- RECURSION //////////////////////////
            ////////////////////////////////////////////////////////////

            Recursion.WakeUp();

            Console.WriteLine(Recursion.FactorialIterative(5));  // Example: prints 120

            Console.WriteLine(Recursion.FactorialRecursive(5));  // Example: prints 120

            Console.WriteLine(Recursion.SumRange(4));

            Console.WriteLine(string.Join(", ", Recursion.CollectOddValues(new List<int> { 1, 2, 3, 4, 5 })));

            List<int> result = Recursion.CollectOddValues(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }


            ////////////////////////////////////////////////////////////
            /////////////////// 05- RECURSION II ///////////////////////
            ////////////////////////////////////////////////////////////


            Console.WriteLine(RecursionII.Factorial(5));

            Console.WriteLine(RecursionII.Fibonacci(5));

            Console.WriteLine(RecursionII.Power(2, 5));

            int[] RecursionIInumbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(RecursionII.ProductOfArray(RecursionIInumbers));

            Console.WriteLine(RecursionII.RecursiveRange(5));

            ////////////////////////////////////////////////////////////
            /////////////////// 06- RECURSION III //////////////////////
            ////////////////////////////////////////////////////////////


            Console.WriteLine(RecursionIII.Reverse("elephant"));

            Console.WriteLine(RecursionIII.IsPalindrome("evitative"));

            int[] someRecursiveNumbers = { 1, 3, 5, 8, 10 };
            Console.WriteLine(RecursionIII.
                SomeRecursive(someRecursiveNumbers, RecursionIII.IsOdd)); // Output: true
            int[] someRecursiveNumbers2 = { 10, 8, 5, 3, 1 };
            Console.WriteLine(RecursionIII.
                SomeRecursive(someRecursiveNumbers2, RecursionIII.IsOdd)); // Output: true

            var nestedArray = new object[] { 1, new object[] { 2, 3 }, 4, new object[] { 5, new object[] { 6, 7 } } };
            var flattenedArray = RecursionIII.Flatten(nestedArray);
            Console.WriteLine(string.Join(", ", flattenedArray)); // Output: 1, 2, 3, 4, 5, 6, 7


            ////////////////////////////////////////////////////////////
            /////////////////// 07- RECURSION IV ///////////////////////
            ////////////////////////////////////////////////////////////

            List<string> words = new List<string> { "hello", "world", "how", "are", "you" };
            List<string> capitalizedWords = RecursionIV.CapitalizeFirst(words);
            foreach (var word in capitalizedWords)
            {
                Console.WriteLine(word);
            }

            List<string> words2 = new List<string> { "hello", "world", "how", "are", "you" };
            List<string> capitalizedWords2 = RecursionIV.CapitalizeWords(words);

            foreach (var word in capitalizedWords)
            {
                Console.WriteLine(word);
            }

            var obj = new Dictionary<string, object>();
            obj.Add("stuff", "foo");
            var data = new Dictionary<string, object>();
            obj.Add("data", data);
            var val = new Dictionary<string, object>();
            data.Add("val", val);
            var thing = new Dictionary<string, object>();
            val.Add("thing", thing);
            thing.Add("info", "bar");
            var moreInfo = new Dictionary<string, object>();
            thing.Add("moreInfo", moreInfo);
            var evenMoreInfo = new Dictionary<string, object>();
            moreInfo.Add("evenMoreInfo", evenMoreInfo);
            evenMoreInfo.Add("weMadeIt", "baz");

            //var obj = new Dictionary<string, object>
            //{
            //{ "stuff", "foo" },
            //{ "data", new Dictionary<string, object>
            //    {
            //        { "val", new Dictionary<string, object>
            //            {
            //                { "thing", new Dictionary<string, object>
            //                    {
            //                        { "info", "bar" },
            //                        { "moreInfo", new Dictionary<string, object>
            //                            {
            //                                { "evenMoreInfo", new Dictionary<string, object>
            //                                    {
            //                                        { "weMadeIt", "baz" }
            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //};

            List<string> collectStringsresult = RecursionIV.CollectStrings(obj);
            Console.WriteLine(string.Join(", ", collectStringsresult));
            // Output: foo, bar, baz

            List<string> collectStringsResultPure = RecursionIV.CollectStringsPure(obj);
            Console.WriteLine(string.Join(", ", collectStringsResultPure));
            // Output: foo, bar, baz

            var obj1 = new Dictionary<string, object>
            {
                { "outer", 2 },
                { "obj", new Dictionary<string, object>
                    {
                        { "inner", 2 },
                        { "otherObj", new Dictionary<string, object>
                            {
                                { "superInner", 2 },
                                { "notANumber", true },
                                { "alsoNotANumber", "yup" }
                            }
                        }
                    }
                }
            };

            var obj2 = new Dictionary<string, object>
            {
                { "a", 2 },
                { "b", new Dictionary<string, object>
                    {
                        { "b", 2 },
                        { "bb", new Dictionary<string, object>
                            {
                                { "b", 3 },
                                { "bb", new Dictionary<string, object>
                                    {
                                        { "b", 2 }
                                    }
                                }
                            }
                        }
                    }
                },
                { "c", new Dictionary<string, object>
                    {
                        { "c", new Dictionary<string, object>
                            {
                                { "c", 2 }
                            }
                        },
                        { "cc", "ball" },
                        { "ccc", 5 }
                    }
                },
                { "d", 1 },
                { "e", new Dictionary<string, object>
                    {
                        { "e", new Dictionary<string, object>
                            {
                                { "e", 2 }
                            }
                        },
                       { "ee", "car" }
                    }
                }
            };


            Console.WriteLine(RecursionIV.NestedEvenSum(obj1)); // 6
            Console.WriteLine(RecursionIV.NestedEvenSum(obj2)); // 10

            //var obj3 = new Dictionary<string, object>
            //{
            //    { "num", 1 },
            //    { "test", new List<object>() },
            //    { "data", new Dictionary<string, object>
            //        {
            //            { "val", 4 },
            //            { "info", new Dictionary<string, object>
            //                {
            //                    { "isRight", true },
            //                    { "random", 66 }
            //                }
            //            }
            //        }
            //    }
            //};

            // Step 1: Create the outer dictionary
            var obj3 = new Dictionary<string, object>();
            obj3["num"] = 1;
            obj3["test"] = new List<object>();

            var dataDict = new Dictionary<string, object>();
            dataDict["val"] = 4;

            var infoDict = new Dictionary<string, object>();
            infoDict["isRight"] = true;
            infoDict["random"] = 66;

            dataDict["info"] = infoDict;

            obj3["data"] = dataDict;

            // Print the result (for demonstration purposes)
            PrintDictionary(obj3);

            // Utility function to print dictionary (for demonstration purposes)
            void PrintDictionary(Dictionary<string, object> dictionary)
            {
                foreach (var kvp in dictionary)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    if (kvp.Value is Dictionary<string, object> nestedDict)
                    {
                        PrintDictionary(nestedDict);
                    }
                }
            }

            ////////////////////////////////////////////////////////////
            ///////////// 08- SEARCHING ALGORITHMS /////////////////////
            ////////////////////////////////////////////////////////////


            int[] arrLS = { 34, 51, 1, 2, 3, 45, 56, 687 };
            int targetLS = 56;
            Console.WriteLine(SearchingAlgorithms.LinearSearch(arrLS, targetLS)); // Output: 6


            int[] arrBS = { 2, 5, 6, 9, 13, 15, 28, 30 };
            int targetBS = 28;
            Console.WriteLine(SearchingAlgorithms.BinarySearch(arrBS, targetBS)); // Output: 6
            Console.WriteLine(SearchingAlgorithms.BinarySearchR(arrBS, targetBS)); // Output: 6

            string longStrSS = "lorie loled";
            string shortStrSS = "lol";
            Console.WriteLine(SearchingAlgorithms.NaiveSearchSS(longStrSS, shortStrSS)); // Output: 1

            ////////////////////////////////////////////////////////////
            /////////////// 09- SORTING ALGORITHMS /////////////////////
            ////////////////////////////////////////////////////////////

            int[] arrBubbleS = { 8, 1, 2, 3, 4, 5, 6, 7 };
            SortingAlgorithms.BubbleSort(arrBubbleS);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arrBubbleS));

            int[] arrOBS = { 8, 1, 2, 3, 4, 5, 6, 7 };
            SortingAlgorithms.OptimizedBubbleSort(arrOBS);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arrOBS));

            int[] arrIS = { 2, 1, 9, 76, 4 };
            SortingAlgorithms.InsertionSort(arrIS);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arrIS));

            int[] arrSS = { 0, 2, 34, 22, 10, 19, 17 };
            SortingAlgorithms.SelectionSort(arrSS);
            Console.WriteLine(string.Join(", ", arrSS));

            int numbertoAnalyze = 48043729;
            int digitPosition = 3;
            int[] numberArraytoAnalyze = { 20, 342210, 1917 };
            SortingAlgorithms.GetDigit(numbertoAnalyze, digitPosition);
            SortingAlgorithms.DigitCount(numbertoAnalyze);
            SortingAlgorithms.MostDigits(numberArraytoAnalyze);

            int[] numsRS = { 23, 345, 5467, 12, 2345, 9852 };
            int[] sortedRS = SortingAlgorithms.RadixSort(numsRS);
            Console.WriteLine(string.Join(", ", sortedRS));
            // Output: 12, 23, 345, 2345, 5467, 9852

            var resultMerge = SortingAlgorithms.
                Merge(new List<int> { 100, 200 },
                new List<int> { 1, 2, 3, 5, 6 });
            Console.WriteLine(string.Join(", ", resultMerge));

            var resultMS = SortingAlgorithms.
                MergeSort(new List<int> { 10, 24, 76, 73, 15, 20, 3, 19 });
            Console.WriteLine(string.Join(", ", resultMS));

            int[] arrPQS = { 4, 8, 2, 1, 5, 7, 6, 3 };
            int pivotIndexPQS = SortingAlgorithms.Pivot(arrPQS, 0, arrPQS.Length - 1);
            Console.WriteLine("Pivot index: " + pivotIndexPQS);
            Console.WriteLine("Array after pivot: " + string.Join(", ", arrPQS));

            int[] arrQS = { 4, 6, 9, 1, 2, 5, 3 };
            SortingAlgorithms.QuickSort(arrQS, 0, arrQS.Length - 1);
            Console.WriteLine("Sorted Array: " + string.Join(", ", arrQS));

            Console.WriteLine(SortingAlgorithms
                .CountZeroes(new int[] { 1, 1, 1, 1, 0, 0 }));
            // Output: 2
            Console.WriteLine(SortingAlgorithms.
                CountZeroes(new int[] { 1, 0, 0, 0, 0 }));
            // Output: 4
            Console.WriteLine(SortingAlgorithms.
                CountZeroes(new int[] { 0, 0, 0 }));
            // Output: 3
            Console.WriteLine(SortingAlgorithms.
                CountZeroes(new int[] { 1, 1, 1, 1 }));
            // Output: 0

            Console.WriteLine(SortingAlgorithms.FindRotatedIndex(new int[] { 3, 4, 1, 2 }, 4)); // Output: 1
            Console.WriteLine(SortingAlgorithms.FindRotatedIndex(new int[] { 6, 7, 8, 9, 1, 2, 3, 4 }, 8)); // Output: 2
            Console.WriteLine(SortingAlgorithms.FindRotatedIndex(new int[] { 6, 7, 8, 9, 1, 2, 3, 4 }, 3)); // Output: 6
            Console.WriteLine(SortingAlgorithms.FindRotatedIndex(new int[] { 37, 44, 66, 102, 10, 22 }, 14)); // Output: -1
            Console.WriteLine(SortingAlgorithms.FindRotatedIndex(new int[] { 6, 7, 8, 9, 1, 2, 3, 4 }, 12)); // Output: -1
            Console.WriteLine(SortingAlgorithms.FindRotatedIndex(new int[] { 11, 12, 13, 14, 15, 16, 3, 5, 7, 9 }, 16)); // Output: 5

            Console.WriteLine(SortingAlgorithms.SortedFrequency(new int[] { 1, 1, 2, 2, 2, 2, 3 }, 2)); // 4
            Console.WriteLine(SortingAlgorithms.SortedFrequency(new int[] { 1, 1, 2, 2, 2, 2, 3 }, 3)); // 1
            Console.WriteLine(SortingAlgorithms.SortedFrequency(new int[] { 1, 1, 2, 2, 2, 2, 3 }, 1)); // 2
            Console.WriteLine(SortingAlgorithms.SortedFrequency(new int[] { 1, 1, 2, 2, 2, 2, 3 }, 4)); // -1

            ////////////////////////////////////////////////////////////
            ////////////// 10- SINGLY LINKED LIST //////////////////////
            ////////////////////////////////////////////////////////////

            SinglyLinkedList SLL1 = new SinglyLinkedList();

            // Initial state
            SLL1.Push("A");
            SLL1.Push("B");
            SLL1.Push("C");
            SLL1.Push("D");
            // List after these operations: "A B C D"
            // Pop removes the last item ("D")
            SLL1.Pop();
            // List after Pop: "A B C" (since D is removed)

            // Shift removes the first item ("A")
            SLL1.Shift();
            // List after Shift: "B C" (A is removed)
            // Unshift inserts "A" at the beginning
            SLL1.Unshift("A");
            // List after Unshift: "A B C" (A is added to the front)

            // Get retrieves the node at index 2 (which is "C" at the moment)
            // Set updates the value at index 2 (from "C" to "c")
            SLL1.Get(2); // Retrieves "C"
            SLL1.Set(2, "c");
            // List after Set: "A B c" (C becomes c)
            // Set updates the value at index 2 again (from "c" to "C")
            SLL1.Set(2, "C");
            // List after Set: "A B C" (c becomes C)

            // Insert inserts "c2" at index 2 (between "B" and "C")
            SLL1.Insert(2, "c2");
            // List after Insert: "A B c2 C"
            // Remove removes the node at index 2 (which is "c2")
            SLL1.Remove(2);
            // List after Remove: "A B C" (c2 is removed)

            SLL1.Print();
            SLL1.Reverse();
            SLL1.Print();
            SLL1.Reverse();
            SLL1.Print();
            // List after last Print: "A B C"

            SLL1.Rotate(2);
            SLL1.Print();
            // List after Rotation: "C A B"


            ////////////////////////////////////////////////////////////
            ////////////// 11- DOUBLY LINKED LIST //////////////////////
            ////////////////////////////////////////////////////////////

            DoublyLinkedList DLL1 = new DoublyLinkedList();

            // Initial state
            DLL1.Push("A");
            DLL1.Push("B");
            DLL1.Push("C");
            DLL1.Push("D");
            // List after these operations: "A B C D"
            // Pop removes the last item ("D")
            DLL1.Pop();
            // List after Pop: "A B C" (since D is removed)

            // Shift removes the first item ("A")
            DLL1.Shift();
            // List after Shift: "B C" (A is removed)
            // Unshift inserts "A" at the beginning
            DLL1.Unshift("A");
            // List after Unshift: "A B C" (A is added to the front)

            // Get retrieves the node at index 2 (which is "C" at the moment)
            // Set updates the value at index 2 (from "C" to "c")
            DLL1.Get(2); // Retrieves "C"
            DLL1.Set(2, "c");
            // List after Set: "A B c" (C becomes c)
            // Set updates the value at index 2 again (from "c" to "C")
            DLL1.Set(2, "C");
            // List after Set: "A B C" (c becomes C)

            // Insert inserts "c2" at index 2 (between "B" and "C")
            DLL1.Insert(2, "c2");
            // List after Insert: "A B c2 C"
            // Remove removes the node at index 2 (which is "c2")
            DLL1.Remove(2);
            // List after Remove: "A B C" (c2 is removed)

            DLL1.Reverse();
            // List after Reverse: "C B A"

        }
    }
}