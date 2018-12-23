using System;

namespace sortingAlgorithmsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSortTest();
        }

        public static void BubbleSortTest()
        {
            var inputArray = new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            BubbleSort.Sort(ref inputArray);
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }
    }
}
