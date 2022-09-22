using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpConcepts.Classes.Exercises;
using System.Collections.Generic;

namespace CSharpConcepts.Tests.Exercises
{
    [TestClass]
    public class IterationExerciseTests
    {

        [TestMethod]
        public void TestNumberOfCenturies()
        {
            List<int> input = new() { 12, 5, -1, 100, 11, 22, 55, 17, 23, -1, 66, 100, 6, 100, 0 };
            int numCenturies = IterationExercises.NumberOfCenturiesScored(input);
            Assert.AreEqual(3, numCenturies);
        }

        [TestMethod]
        public void TestBattingAverage()
        {
            List<int> input = new() { 12, 5, -1, 100, 11, 22, 55, 17, 23, -1, 66, 100, 6, 100, 0 };
            double battingAverage = IterationExercises.BattingAverage(input);
            Assert.AreEqual(39.76923076923077, battingAverage, 0.001);
        }
    }
}
