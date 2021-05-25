using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.Searching
{
    public class BasicSearching
    {
        public static int BinarySearch(int target, int[] source)
        {
            int min = 0;
            int max = source.Length - 1;
            while (min < max)
            {
                int middle = (min + max) / 2;
                if (source[middle] == target)
                {
                    return middle;
                }
                else if (target < source[middle])
                {
                    max = middle - 1;
                }
                else
                {
                    min = middle + 1;
                }
            }
            return -1; 
        }
    }
}
