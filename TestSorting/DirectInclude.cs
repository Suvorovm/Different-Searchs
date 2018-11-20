using System;
using System.Diagnostics;
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
            long a = 0, b = 0;
            algorithms.DirectInclude(input);
            foreach (var item in input)
            {
                Debug.WriteLine(item.ToString() + " ");
            }
            input[0] = 0;
            CollectionAssert.AreEqual(input, actual);
        }

        [TestMethod]
        public void TestMethod1()
        {
            SendToDirectInclude(new int[] {0, 5, 4, 3, 2, 1, 0 });
        }
               

        [TestMethod]
        public void TestMethodBigvalueSorted()
        {
            SendToDirectInclude(new int[] { 0,12 ,100 ,200 ,500 ,600 ,700,800,900,901,902});
        }

        [TestMethod]
        public void TestMethodCheckMany()
        {
            SendToDirectInclude(new int[] { 0, 5,1,2,9,55,88,66,92,34,55,66,999,888});
        }
        [TestMethod]
        public void StartEmeny()
        {
            SendToDirectInclude(new int[] { 0, 98,97,96,95,94,93,92,91,90});
        }
        [TestMethod]
        public void StartEmeny2()
        {
            SendToDirectInclude(new int[] { 0, 10,9,8,7,6,5,4,3,2,1, });
        }
    }
}
