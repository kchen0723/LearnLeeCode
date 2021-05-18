using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnLeeCode.Sorting.Tests
{
    [TestClass()]
    public class BasicSortingTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            var input = new int[] { 3, 1, 4 };
            var result = BasicSorting.BubbleSort(input);
        }
    }
}