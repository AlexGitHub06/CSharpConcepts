using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpConcepts.Classes.Examples;
using System.Collections.Generic;

namespace CSharpConcepts.Tests
{
    [TestClass]
    public class IterationExampleTests
    {
        [TestMethod]
        [DataRow(-1, 0)]
        [DataRow(10, 55)]
        [DataRow(100, 5050)]
        public void TestSumOfNNumbers(int input, int expectedValue)
        {
            int total = IterationExamples.Sum(input);
            Assert.AreEqual(expectedValue, total);
        }

        [TestMethod]      
        public void TestSquaredNumbers()
        {
            List<double> input = new() { 0.5, 4, 0.25, 1, 2, -3 };
            List<double> expected = new() { 0.25, 16, 0.0625, 1, 4, 9 };
            List<double> squaredNumbers = IterationExamples.SquaredNumbers(input);
            CollectionAssert.AreEqual(expected, squaredNumbers);
        }
    }
}