using System;
using DifferentSearchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSorting
{
    [TestClass]
    public class TestDirect
    {
        public void SendToDirectExchange(int[] input)
        {
            SearchsAlgorithms algorithms = new SearchsAlgorithms();
            int[] actual = new int[input.Length];
            Array.Copy(input, actual,input.Length);
            Array.Sort(actual);
            algorithms.DirectExchange(input);
            CollectionAssert.AreEqual(input, actual);

        } 
        [TestMethod]
        public void DirectExchangeTest_1()
        {
            int[] input = new int[] {1,8,5,4,3,2,1 };
            SendToDirectExchange(input);
        }

        [TestMethod]
        public void DirectExchangeTest_2()
        {
            int[] input = new int[] { 1, 1, 1, 1, 1, 2, 1 };
            SendToDirectExchange(input);
        }

        [TestMethod]
        public void DirectExchangeTest_3()
        {
            int[] input = new int[] {5,6,516,15,5,895,657,5651,265,320,48121,8162};
            SendToDirectExchange(input);
        }
    }
}
