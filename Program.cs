using System;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgorithmsCSharp
{
    class Program
    {
        private static readonly int[] _sortedArray = new int[] { 0, 1, 2, 4, 5, 6, 44, 63, 87, 99, 283 };
        static void Main(string[] args)
        {
            //BubbleSortTest();
            //SelectionSortTest();
            //InsertionSortTest();
            MergeSortTest();
        }

        public static void BubbleSortTest()
        {
            var inputArray = new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            BubbleSort.Sort(ref inputArray);
            
            Debug.Assert(Enumerable.SequenceEqual(inputArray, _sortedArray));
            
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }

        public static void SelectionSortTest()
        {
            var inputArray = new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            SelectionSort.Sort(ref inputArray);
            
            Debug.Assert(Enumerable.SequenceEqual(inputArray, _sortedArray));
            
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }

        public static void InsertionSortTest()
        {
            var inputArray = new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            InsertionSort.Sort(ref inputArray);
            
            Debug.Assert(Enumerable.SequenceEqual(inputArray, _sortedArray));
            
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }

        public static void MergeSortTest()
        {
            var inputArray = new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            MergeSort.Sort(ref inputArray);
            
            Debug.Assert(Enumerable.SequenceEqual(inputArray, _sortedArray));
            
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }
    }
}
