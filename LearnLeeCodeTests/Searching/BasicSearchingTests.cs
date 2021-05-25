using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnLeeCode.Searching;
using System;
using System.Collections.Generic;
using System.Text;
using LearnLeeCodeTests;

namespace LearnLeeCode.Searching.Tests
{
    [TestClass()]
    public class BasicSearchingTests
    {
        [TestMethod()]
        public void BinarySearchTest()
        {
            var input = RandomList.GetSortedRandomArray(11);
            var resultIndex = BasicSearching.BinarySearch(5, input);
        }
    }
}