using System;
using System.Linq;

//Space complexity is O(n)
//Time completxity is O(nlgn)
//Merge sort is one of the most efficient way to sort a list.
namespace SortingAlgorithmsCSharp
{
    public class MergeSort
    {
        public static void Sort(ref int[] inputArray)
        {
            if (inputArray.Length > 1) {
                int mid = inputArray.Length / 2;
                var  left = (int[] )inputArray.Take(mid).ToArray();
                var  right = (int[] )inputArray.Skip(mid).ToArray();
                Sort(ref left);
                Sort(ref right);

                int i = 0, j = 0, k = 0;
                while (i < left.Length && j < right.Length)
                {
                    if (left[i] < right[j])
                    {
                        inputArray[k] = left[i];
                        i++;
                        k++;
                    }
                    else if (left[i] > right[j])
                    {
                        inputArray[k] = right[j];
                        j++;
                        k++;
                    }
                    
                }

                while (i < left.Length)
                {
                    inputArray[k] = left[i];
                    i++;
                    k++;
                }

                while (j < right.Length)
                {
                    inputArray[k] = right[j];
                    j++;
                    k++;
                }
            }
        }
    }
}