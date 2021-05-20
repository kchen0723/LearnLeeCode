using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnLeeCodeTests.Sorting;
using System;
using System.Collections.Generic;
using System.Text;
using LearnLeeCodeTests;

namespace LearnLeeCodeTests.Sorting.Tests
{
    [TestClass()]
    public class AdvancedSortingTests
    {
        [TestMethod()]
        public void ShellSortTest()
        {
            var input = RandomList.GetRandomArray(7);
            var result = AdvancedSorting.ShellSort(input);
            RandomList.PrintRandomArray(result);
        }
    }
}