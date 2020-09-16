using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoryClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatoryClassLibraryTests
{
    [TestClass()]
    public class CykelTests
    {
        private static readonly Cykel Cykel = new Cykel(1, "Rd", (decimal)2499.95, 7);

        [TestInitialize]
        public void Init()
        {
            Cykel.Id = 1;
            Cykel.Farve = "Rd";
            Cykel.Pris = 2499;
            Cykel.Gear = 7;
        }

        [TestMethod()]
        public void IdTest()
        {
            Assert.IsInstanceOfType(Cykel.Id, typeof(int), "Invalid type for Cykel.Id");
        }

        [TestMethod]
        public void FarveTest()
        {
            Assert.IsInstanceOfType(Cykel.Farve, typeof(string), "Invalid type for Cykel.Farve");

            Assert.AreEqual(2, Cykel.Farve.Length);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Cykel.Farve = "T");
        }

        [TestMethod]
        public void PrisTest()
        {
            Assert.AreEqual(2499, Cykel.Pris);

            Cykel.Pris = 0;
            Assert.AreEqual(0, Cykel.Pris);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Cykel.Pris = -1);
        }

        [TestMethod]
        public void GearTest()
        {
            Assert.AreEqual(7, Cykel.Gear);

            Cykel.Gear = 3;
            Assert.AreEqual(3, Cykel.Gear);

            Cykel.Gear = 32;
            Assert.AreEqual(32, Cykel.Gear);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Cykel.Gear = 2);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Cykel.Gear = 33);
        }
    }
}