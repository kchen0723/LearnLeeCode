using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.Sorting
{
    public class BasicSorting
    {
        public static int[] BubbleSort(int[] input)
        {
            int temp = 0;
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = i; j < input.Length; j++)
                {
                    if (input[i] < input[j])
                    {
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
    }
}
