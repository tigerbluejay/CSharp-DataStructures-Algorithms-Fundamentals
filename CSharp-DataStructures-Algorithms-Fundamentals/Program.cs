﻿using CSharp_DataStructures_Algorithms_Fundamentals._10_Singly_Linked_List;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Linq;
using static CSharp_DataStructures_Algorithms_Fundamentals.StacksandQueues;

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


            ////////////////////////////////////////////////////////////
            ////////////// 12- STACKS AND QUEUES  //////////////////////
            ////////////////////////////////////////////////////////////
            ///
            CustomStack stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            // LIFO 3,2,1

            CustomQueue queue = new CustomQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
			// FIFO 2,3,4

			////////////////////////////////////////////////////////////
			////////////// 13- BINARY SEARCH TREES  /////////////////////
			////////////////////////////////////////////////////////////

            BinarySearchTree bst = new BinarySearchTree();
            //      10
            //   5     13
            // 2  7  11  16
            bst.Insert(10);
            bst.Insert(5);
            bst.Insert(13);
            bst.Insert(7);
            bst.Insert(11);
            bst.Insert(16);
            bst.Insert(2);

            BSTNode bsfindtres = bst.Find(11); // returns node with val 11
            bool bstcontainsres = bst.Contains(11); // true

            bst.Remove(11); // removes node with val 11

            List<int> preOrderRes = bst.DFSPreOrder(); // 10 5 2 7 13 11 16 
			List<int> InOrderRes = bst.DFSInOrder(); // 2 5 7 10 11 13 16
			List<int> postOrderRes = bst.DFSPostOrder(); // 2 7 5 11 16 13 10
			List<int> bfsRes = bst.BFS(); // 10 4 13 2 7 11 16

            // if tree were:
            //          10
            //        6     15
            //      3   8      20

            // Depth First Pre Order: 10 6 3 8 15 20
            // Depth First In Order: 3 6 8 10 15 20
            // Depth First Post Order: 3 8 6 20 15 10
            // Breadth First: 10 6 15 3 8 20

            bool isTreeBalanced = bst.IsBalanced(); // true
            /*
            CheckHeight(10)
            ├── CheckHeight(5)
            │   ├── CheckHeight(2)
            │   │   ├── CheckHeight(null) → 0
            │   │   ├── CheckHeight(null) → 0
            │   │   └── Max(0, 0) + 1 → 1
            │   ├── CheckHeight(7)
            │   │   ├── CheckHeight(null) → 0
            │   │   ├── CheckHeight(null) → 0
            │   │   └── Max(0, 0) + 1 → 1
            │   └── Max(1, 1) + 1 → 2
            ├── CheckHeight(13)
            │   ├── CheckHeight(11)
            │   │   ├── CheckHeight(null) → 0
            │   │   ├── CheckHeight(null) → 0
            │   │   └── Max(0, 0) + 1 → 1
            │   ├── CheckHeight(16)
            │   │   ├── CheckHeight(null) → 0
            │   │   ├── CheckHeight(null) → 0
            │   │   └── Max(0, 0) + 1 → 1
            │   └── Max(1, 1) + 1 → 2
            └── Max(2, 2) + 1 → 3
            */

            BSTNode largestNode = bst.FindLargestNode(bst.Root); // find the largest, in this case: 16
                                                                 //      10
                                                                 //   5     13
                                                                 // 2  7  11  16

            int? secondLargestNode = bst.FindSecondLargest();  // in this case 13


			////////////////////////////////////////////////////////////
			////////////// 14- BINARY HEAP /////////////////////////////
			////////////////////////////////////////////////////////////

			MaxBinaryHeap heap = new MaxBinaryHeap();
			// (P denotes the parent of the last element inserted)
	        heap.Insert(41); // 41P
			heap.Insert(39); // 41P (39)
			heap.Insert(33); // 41P (39 33)
			heap.Insert(18); // 41 39P 33 (18)
			heap.Insert(27); // 41 39P 33 (18 27)
			heap.Insert(12); // 41 39 33P 18 27 (12)
			heap.Insert(55); // 41 39 33P 18 27 (12 55) => swap parent for child
			                 // (because child 55 is greater than parent 33)
					         // 41 39 55P 18 27 (12 33) 
				             // 55P (39 41) 18 27 12 33 => swap parent for child
					         // (because child 55 is greater than parent 41)
        	heap.PrintHeap();

            int maxHeapval = heap.ExtractMax(); // obtain max heap val, and evaluate heap to see how it's been rearranged (with sink down)
												// 41 39 33 18 27 12


			PriorityQueue ER = new PriorityQueue();

			// Order of calls and expected behavior:

			ER.Enqueue("common cold", 5);
			ER.Enqueue("gunshot wound", 1);
			// Gunshot wound (1) is compared to common cold (5) and swapped to root.

			ER.Enqueue("high fever", 4);
			// High fever (4) is placed as the right child of common cold (5).

			ER.Enqueue("broken arm", 2);
			// Broken arm (2) is compared to common cold (5) and swapped.
			// Then compared to gunshot wound (1) and not swapped.

			ER.Enqueue("glass in foot", 3);
			// Glass in foot (3) is placed as the child of broken arm (2) without needing to swap.

			ER.Dequeue();
            // Gunshot wound (1) is removed and the heap is rearranged.
            // Broken arm (2) becomes the new root, and the heap is adjusted.

            ////////////////////////////////////////////////////////////
            ////////////// 15- HASH TABLES /////////////////////////////
            ////////////////////////////////////////////////////////////

            // creates a hash for the string
            int hashResult = HashTables.Hash("josemariairiarte", 5);
			int hashResult2 = HashTables.Hash2("josemariairiarte", 5);

            HashTables hashTable = new HashTables();

            // sets key value pairs in a List<keyvaluepairs<string,string>>
            // the amount of items in the list will depend on the Hash funcion
			hashTable.Set("teacher", "mary");
			hashTable.Set("professor", "john");
			hashTable.Set("developer", "jose");
			string HTvalue = hashTable.Get("developer"); // jose

            List<string> HTkeys = hashTable.Keys(); // "teacher", "professor", "developer"
            List<string> HTvalues = hashTable.Values(); // "mary", "john", "jose"


            ////////////////////////////////////////////////////////////
            ////////////////// 16 - GRAPHS /////////////////////////////
            ////////////////////////////////////////////////////////////

            Graph graph = new Graph();

            graph.AddVertex("A");
			graph.AddVertex("B");
			graph.AddVertex("C");
			graph.AddVertex("D");
			graph.AddVertex("E");
			graph.AddVertex("F");

            graph.AddEdge("A", "B");
			graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
			graph.AddEdge("C", "E");
			graph.AddEdge("D", "E");
			graph.AddEdge("D", "F");
			graph.AddEdge("E", "F");

            //          A
            //        /   \
            //       B     C
            //       |     |
            //       D --- E
            //        \   /
            //          F

            List<string> graphResult1 = graph.DepthFirstRecursive("A"); // A, B, D, E, C, F

            // iterative solution adds to the stack all the neighbors and pops the last, that's
            // why we start with A, add B and C, and pop C and so forth *instead of B like in the recursive solution.
			List<string> graphResult2 = graph.DepthFirstIterative("A"); // A, C, E, F, D, B

			List<string> graphResult3 = graph.BreadthFirst("A"); // A, B, C, D, E, F

			//////////////////////////////////////////////////////////////////
			////////// 17 - DIJKSTRA'S ALGORITHM /////////////////////////////
			//////////////////////////////////////////////////////////////////


			var wgraph = new WeightedGraph();
			wgraph.AddVertex("A");
			wgraph.AddVertex("B");
			wgraph.AddVertex("C");
			wgraph.AddVertex("D");
			wgraph.AddVertex("E");
			wgraph.AddVertex("F");

			wgraph.AddEdge("A", "B", 4);
			wgraph.AddEdge("A", "C", 2);
			wgraph.AddEdge("B", "E", 3);
			wgraph.AddEdge("C", "D", 2);
			wgraph.AddEdge("D", "E", 3);
			wgraph.AddEdge("D", "F", 1);
			wgraph.AddEdge("E", "F", 1);
			/*
				 A
				/ \
			   2   4
			  /     \
			 C-------B
			 |       |
			 2       3
			 |       |
			 D---3---E
			  \     /
			   1   1
				\ /
				 F
			*/
			List<string> wgraphresult = wgraph.Dijkstra("A", "E");
			Console.WriteLine(string.Join(" -> ", wgraphresult)); // A -> C -> D -> F -> E (6)

			var wgraph2 = new WeightedGraph2();
			wgraph2.AddVertex("A");
			wgraph2.AddVertex("B");
			wgraph2.AddVertex("C");
			wgraph2.AddVertex("D");
			wgraph2.AddVertex("E");
			wgraph2.AddVertex("F");

			wgraph2.AddEdge("A", "B", 4);
			wgraph2.AddEdge("A", "C", 2);
			wgraph2.AddEdge("B", "E", 3);
			wgraph2.AddEdge("C", "D", 2);
			wgraph2.AddEdge("D", "E", 3);
			wgraph2.AddEdge("D", "F", 1);
			wgraph2.AddEdge("E", "F", 1);

			List<string> wgraph2result = wgraph2.Dijkstra("A", "E");
			Console.WriteLine(string.Join(" -> ", result)); // A -> C -> D -> F -> E (6)


            //////////////////////////////////////////////////////////////////
            ////////// 18 - DYNAMIC PROGRAMMING  /////////////////////////////
            //////////////////////////////////////////////////////////////////

            int fibonacciRes = DynamicProgramming.Fibonacci(6);
            int fibonacciRes2 = DynamicProgramming.FibonacciMemoized(6);
            int fibonacciRes3 = DynamicProgramming.FibonacciBottomUp(6);

            int[] coinDenominations = [1, 2, 5];
            int tragetAmount = 5;
            int coinProblemRes = DynamicProgramming.CountWaysToMakeChange(coinDenominations, tragetAmount);

            //////////////////////////////////////////////////////////////////
            //////////////////////// 19 - TRIES  /////////////////////////////
            //////////////////////////////////////////////////////////////////

            Trie trie = new Trie();
            trie.AddWord("fun");
			trie.AddWord("fast");
			trie.AddWord("fat");
			trie.AddWord("fate");
			trie.AddWord("father");
			trie.AddWord("forget");
			trie.AddWord("awesome");
			trie.AddWord("argue");

            Trie trieRes = trie.FindWord("fate");
			// awe is not a word so it returns false, but other characters returnes include s from "awesome"
			Trie trieRes2 = trie.FindWord("awe"); 

            List<string> wordsGot = trie.GetWords();
			List<string> wordsAutocompleted = trie.AutoComplete("fat");

            trie.RemoveWord("argue");
			List<string> wordsGot2 = trie.GetWords();

            Console.WriteLine();
		}
	}
}