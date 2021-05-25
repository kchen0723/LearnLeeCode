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

        public static int ResursiveBinarySearch(int target, int[] source)
        {
            return RunResursiveBinarySearch(target, source, 0, source.Length - 1);
        }

        private static int RunResursiveBinarySearch(int target, int[] source, int min, int max)
        {
            if (min >= max)
            {
                return -1;
            }
            else
            {
                int middle = (min + max) / 2;
                if (target < source[middle])
                {
                    return RunResursiveBinarySearch(target, source, min, middle - 1);
                }
                else if (target == source[middle])
                {
                    return middle;
                }
                else
                {
                    return RunResursiveBinarySearch(target, source, middle + 1, max);
                }
            }
        }
    }
}
