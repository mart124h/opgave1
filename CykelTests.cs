using UnitTestCykel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestCykel.Tests
{
    [TestClass()]
    public class CykelTests
    {
        [TestMethod()]
        public void GearTest()
        {
            Cykel cykel1 = new Cykel(1, "blå", 2000.0, 12);
            Assert.AreEqual(12, cykel1.Gear);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel1.Gear = 1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel1.Gear = 33);

        }

        [TestMethod()]
        public void PrisTest()
        {
            Cykel cykel2 = new Cykel(2, "sort", 4000.0, 7);
        
            Assert.AreEqual(4000.0, cykel2.Pris);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => cykel2.Pris = -33.0);
        }

        [TestMethod()]
        public void FarveTest()
        {
            Cykel cykel3 = new Cykel(3, "gul", 300.0, 7);
            Assert.AreEqual("gul", cykel3.Farve);

            Assert.ThrowsException<ArgumentException>(() => cykel3.Farve = "");

        }
    }
}