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
        private static readonly Cykel _cykel = new Cykel(1, "Rd", (decimal)2499.95, 7);

        [TestInitialize]
        public void Init()
        {
            _cykel.Id = 1;
            _cykel.Farve = "Rd";
            _cykel.Pris = 2499;
            _cykel.Gear = 7;
        }

        [TestMethod()]
        public void IdTest()
        {
            Assert.IsInstanceOfType(_cykel.Id, typeof(int), "Invalid type for Cykel.Id");
        }

        [TestMethod]
        public void FarveTest()
        {
            Assert.IsInstanceOfType(_cykel.Farve, typeof(string), "Invalid type for Cykel.Farve");

            Assert.AreEqual(2, _cykel.Farve.Length);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Farve = "T");
        }

        [TestMethod]
        public void PrisTest()
        {
            Assert.AreEqual(2499, _cykel.Pris);

            _cykel.Pris = 0;
            Assert.AreEqual(0, _cykel.Pris);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Pris = -1);
        }

        [TestMethod]
        public void GearTest()
        {
            Assert.AreEqual(7, _cykel.Gear);

            _cykel.Gear = 3;
            Assert.AreEqual(3, _cykel.Gear);

            _cykel.Gear = 32;
            Assert.AreEqual(32, _cykel.Gear);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 2);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 33);
        }
    }
}