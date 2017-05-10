using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroToTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CacluatorAddTests
    {
        [TestMethod]
        public void BasicAdd()
        {
            // Arrange
            var caclulator = new Calculator();
            // Act
            var total = caclulator.Add(2, 3);
            // Assert
            Assert.AreEqual(5, total);
        }

        [TestMethod]
        public void AddPositiveAndNegative()
        {
            // Arrange
            var calc = new Calculator();
            // Act
            var total = calc.Add(10, -20);
            // Assert
            Assert.AreEqual(-10, total);
        }


        [TestMethod]
        public void AddZeroAndPositive()
        {
            // Arrange
            var calc = new Calculator();
            // Act
            var total = calc.Add(0, 20);
            // Assert
            Assert.AreEqual(20, total);
        }
    }
}
