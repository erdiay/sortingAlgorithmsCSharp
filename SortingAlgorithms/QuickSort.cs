using System;
using System.Linq;

//Space complexity is O(lgn)
//Time completxity is O(nlgn). (Actually this is avarage. If array is already sorted, the complexity will be O(n^2))
//Note that this is not a stable sorting algorithm
namespace SortingAlgorithmsCSharp
{
    public class QuickSort
    {
        public static void Sort(ref int[] inputArray)
        {
            InternalSort(ref inputArray, 0, inputArray.Length - 1);
        }

        private static void InternalSort(ref int[] inputArray, int low, int high)
        {
            if (low < high)
            {
                var partitionIndex = Partition(ref inputArray, low, high);
                InternalSort(ref inputArray, low, partitionIndex - 1);
                InternalSort(ref inputArray, partitionIndex + 1, high);
            }
        }

        private static int Partition(ref int[] inputArray, int low, int high)
        {
            int i = low, j = low;
            var pivot = inputArray[high];
            for (j = low; j < high; j++)
            {
                if (inputArray[j] < pivot)
                {
                    if (i != j)
                    {
                        Swap(ref inputArray, i, j);
                    }
                    i++;
                }
            }
            Swap(ref inputArray, i, high);

            return i;
        }

        private static void Swap(ref int[] inputArray, int i, int j)
        {
            var temp = inputArray[i];
            inputArray[i] = inputArray[j];
            inputArray[j] = temp;
        }
    }
}