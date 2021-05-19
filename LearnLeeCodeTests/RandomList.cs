using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCodeTests
{
    public class RandomList
    {
        public static List<int> GetRandomList(int length)
        {
            Random rnd = new Random(length);
            List<int> result = new List<int>();
            for (int i = 0; i < length; i++)
            {
                result.Add(rnd.Next(length));
            }
            return result;
        }

        public static int[] GetRandomArray(int length)
        {
            return GetRandomList(length).ToArray();
        }

        public static int[] GetSortedRandomArray(int length)
        {
            var result = GetRandomArray(length);
            Array.Sort(result);
            return result;
        }

        public static void PrintRandomArray(int[] array)
        {
            var result = string.Join(',', array);
            Console.WriteLine(result);
        }
    }
}
