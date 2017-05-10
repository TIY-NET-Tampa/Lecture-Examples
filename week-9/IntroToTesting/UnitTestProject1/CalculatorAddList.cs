using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroToTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class List
    {

        // list has some numbesr in it
        [TestMethod]
        public void AddListOfNumbers()
        {
            var total = new Calculator().Add(new List<int?> { 1, 2, 3, 4, 5, 6 });
            Assert.AreEqual(21, total);

        }

        // List could nothing -- shouldnt crash
        [TestMethod]
        public void EmptyList()
        {
            var total = new Calculator().Add(new List<int?>());
            Assert.AreEqual(0, total);

        }
        // one item could be null -- shouldnt crash
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddListWithNullItems()
        {
            new Calculator().Add(new List<int?> { 1, 2, 3, null });
        }

        // list could be null -- should crash
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullList()
        {
            new Calculator().Add(null);
        }


    }
}
