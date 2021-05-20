using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LearnLeeCodeTests;

namespace LearnLeeCode.Sorting.Tests
{
    [TestClass()]
    public class BasicSortingTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            var input = RandomList.GetRandomArray(10);
            var result = BasicSorting.BubbleSort(input);
            RandomList.PrintRandomArray(result);
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            var input = RandomList.GetRandomArray(10);
            var result = BasicSorting.SelectionSort(input);
            RandomList.PrintRandomArray(result);
        }

        [TestMethod()]
        public void InsertionSortTest()
        {
            var input = RandomList.GetRandomArray(10);
            var result = BasicSorting.InsertionSort(input);
            RandomList.PrintRandomArray(result);
        }
    }
}