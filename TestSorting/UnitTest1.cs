using System;
using DifferentSearchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSorting
{
    [TestClass]
    public class UnitTest1
    {
        public void SendToDirectSelection(int[] input)
        {
            SearchsAlgorithms algorithms = new SearchsAlgorithms();
            int[] actual = new int[input.Length];
            Array.Copy(input, actual,input.Length);
            Array.Sort(actual);
            algorithms.DirectSelection(input);
            CollectionAssert.AreEqual(input, actual);

        } 
        [TestMethod]
        public void DirectSelecthionTest()
        {
            int[] input = new int[] {1,8,5,4,3,2,1 };
            SendToDirectSelection(input);
        }
    }
}
