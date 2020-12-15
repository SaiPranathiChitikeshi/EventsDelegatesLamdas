using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class SimpleLamdaTest
    {
        [TestMethod]
        public void EventNumberTest()
        {
            //dataset
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
            SimpleLambda lambda = new SimpleLambda();
            var evenNumbers = lambda.EvenNumbers(numbers);
            Assert.AreEqual(evenNumbers.Count(), 4);
        }

        [TestMethod]
        public void SquareTest()
        {
            //dataset
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
            SimpleLambda lambda = new SimpleLambda();
            var squares = lambda.SquareNumber(numbers);
            Assert.AreEqual(squares.Count(), 10);
            Assert.AreEqual(squares.First(), 1296);
        }
    }
}
