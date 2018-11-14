using System;
using System.Diagnostics;
using DifferentSearchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSorting
{
    [TestClass]
    public class UnitTest1
    {
        public void SendToDirectChange(int[] input)
        {
            SearchsAlgorithms algorithms = new SearchsAlgorithms();
            int[] actual = new int[input.Length];
            Array.Copy(input, actual, input.Length);
            Array.Sort(actual);
            algorithms.DirectChange(input);
            for (int i = 0; i < actual.Length; i++)
            {
                Debug.Write(input[i] + " ");
            }
            CollectionAssert.AreEqual(input, actual);

        }
        [TestMethod]
        public void TestMethod1()
        {
            SendToDirectChange(new int[] { 1, 8, 2, 6, 72 });
        }

        [TestMethod]
        public void testMetodSorted()
        {
            SendToDirectChange(new int[]{1,2,3,4,5,6,0});
        }

        [TestMethod]
        public void testMetodEmpty()
        {
            SendToDirectChange(new int[] {});
        }
    }
}
