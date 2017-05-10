using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroToTesting;
using IntroToTesting.DataContext;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class IntegrationTestCalcuatorAdd
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var calc = new Calculator();
            // Act
            var total = calc.AddAndSaveToDatasebase(3, 5);
            // Assert
            var expectedTotal = "8";
            Assert.AreEqual(expectedTotal, total.Result);
            // this says taht is inserted the database
            Assert.AreNotEqual(0, total.Id);

            var db = new CalcContext();
            var inserted = db.Answers.FirstOrDefault(f => f.Id == total.Id);
            Assert.IsNotNull(inserted);

   
        }
    }
}
