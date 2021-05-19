using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.Sorting
{
    public class BasicSorting
    {
        public static int[] BubbleSort(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = i; j < input.Length; j++)
                {
                    if (input[i] < input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }

        public static int[] SelectionSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                var minIndex = i;
                for (int j = i; j < input.Length; j++)
                {
                    if (input[minIndex] > input[j])
                    {
                        minIndex = j;
                    }
                }
                var temp = input[i];
                input[i] = input[minIndex];
                input[minIndex] = temp;
            }
            return input;
        }
    }
}
