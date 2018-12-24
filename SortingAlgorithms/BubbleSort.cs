using System;

//Space complexity is O(1)
//Time completxity is O(n^2)
namespace SortingAlgorithmsCSharp
{
    public class BubbleSort
    {
        public static void Sort(ref int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    if (inputArray[j + 1] < inputArray[j])
                    {
                        var temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }
                }
            }
        }
    }
}