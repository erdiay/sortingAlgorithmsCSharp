using System;

//Space complexity is O(1)
//Time completxity is O(n^2)
namespace SortingAlgorithmsCSharp
{
    public class SelectionSort
    {
        public static void Sort(ref int[] inputArray)
        {
            var length = inputArray.Length;
            for (int i = 0; i < length; i++)
            {
                var min = inputArray[i];
                var minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (min > inputArray[j])
                    {
                        min = inputArray[j];
                        minIndex = j;
                    }
                }
                inputArray[minIndex] = inputArray[i];
                inputArray[i] = min;
            }
        }
    }
}