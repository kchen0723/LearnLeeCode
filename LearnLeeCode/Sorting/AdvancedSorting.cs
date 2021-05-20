using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCodeTests.Sorting
{
    public class AdvancedSorting
    {
        public static int[] ShellSort(int[] input)
        {
            int i = 0;
            int j = 0;
            int stepLength = 0;
            while (stepLength <= input.Length / 3)
            {
                stepLength = stepLength * 3 + 1;
            }
            while (stepLength > 0)
            {
                for ( i = stepLength; i < input.Length; i++)
                {
                    int temp = input[i];
                    j = i;
                    while (j > stepLength - 1 && input[j - stepLength] > temp)
                    {
                        input[j] = input[j - stepLength];
                        j -= stepLength;
                    }
                    input[j] = temp;
                }
                stepLength = (stepLength - 1) / 3;
            }
            return input;
        }
    }
}
