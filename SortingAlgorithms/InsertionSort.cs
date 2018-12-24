using System;

//Space complexity is O(1)
//Time completxity is O(n^2)
//When it comes to small datasets or nearly sorted datasets, you wanna use insertion sort over other sorting algorithms
namespace SortingAlgorithmsCSharp
{
    public class InsertionSort
    {
        public static void Sort(ref int[] inputArray)
        {
            var length = inputArray.Length;
            for (int i = 1; i < length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (inputArray[j + 1] < inputArray[j])
                    {
                        var temp = inputArray[j + 1];
                        inputArray[j + 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
        }
    }
}