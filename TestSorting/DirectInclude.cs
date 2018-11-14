using System;
using DifferentSearchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSorting
{
    [TestClass]
    public class DirectInclude
    {
        public void SendToDirectInclude(int[] input)
        {
            SearchsAlgorithms algorithms = new SearchsAlgorithms();
            int[] actual = new int[input.Length];
            Array.Copy(input, actual, input.Length);
            Array.Sort(actual);
            algorithms.DirectInclude(input);
            CollectionAssert.AreEqual(input, actual);
        }

        [TestMethod]
        public void TestMethod1()
        {
            SendToDirectInclude(new int[] { 5, 4, 3, 2, 1, 0 });
        }

        [TestMethod]
        public void TestMethod_nullVlue ()
        {
            SendToDirectInclude(new int[] {});
        }

        [TestMethod]
        public void TestMethodBigvalueSorted()
        {
            SendToDirectInclude(new int[] { 12 ,100 ,200 ,500 ,600 ,700,800,900,901,902});
        }
    }
}
