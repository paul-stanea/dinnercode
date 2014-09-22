using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dinnercode_PrimeFactors.Test
{
    [TestClass]
    public class DinnercodePrimeFactorsTests
    {
        [TestMethod]
        public void TestGenerate()
        {
            PrimeFactors.Generate(0);
        }

        [TestMethod]
        public void TestGenerateReturnsEmptyListForNumbersSmallerThan2()
        {
            var factors = PrimeFactors.Generate(2);

            Assert.AreEqual(1, factors.Count);
        }

        [TestMethod]
        public void TestGenerateDoesNotReturn0ForNumberGreaterThan2()
        {
            var factors = PrimeFactors.Generate(6);

            Assert.AreEqual(2, factors.Count);
            CollectionAssert.AreEqual(new List<int>{2,3}, factors);
        }
    }
}
