using System;
using System.Diagnostics;
using DifferentSearchs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSorting
{
    [TestClass]
    public class ShellSort
    {

        public void SendTOShellSort(int[] input)
        {
            SearchsAlgorithms algorithms = new SearchsAlgorithms();
            int[] actual = new int[input.Length];
            Array.Copy(input, actual, input.Length);
            Array.Sort(actual);
            algorithms.SortingByShell(input);
            for (int i = 0; i < actual.Length; i++)
            {
                Debug.Write(input[i] + " ");
            }
            CollectionAssert.AreEqual(input, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            SendTOShellSort(new int[] { 5, 4, 3, 2, 1, 0 });
        }
    }
}
