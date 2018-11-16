using System;
using System.Diagnostics;
using DifferentSearchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSorting
{
    [TestClass]
    public class LineSorting
    {
        public void SentToLineSort(int[] input)
        {
            SearchsAlgorithms algorithms = new SearchsAlgorithms();
            int[] actual = new int[input.Length];
            Array.Copy(input, actual, input.Length);
            Array.Sort(actual);
            algorithms.LineSorting(input);
           
            CollectionAssert.AreEqual(input, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            SentToLineSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
        }
        [TestMethod]
        public void TestMethod2()
        {
            SentToLineSort(new int[] { 10,10,10,10,1,0,10,10,10 });
        }
        [TestMethod]
        public void TestMethodEmty()
        {
            SentToLineSort(new int[] { });
        }
    }
}
