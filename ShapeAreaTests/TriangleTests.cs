using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeAreaForInternship;

namespace ShapeAreaTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void ZeroSide()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(12.84, 0, 11.361).CalculateArea());
        }
        
        [TestMethod]
        public void DecimalSides()
        {
            Assert.AreEqual(2.342, new Triangle(3.547, 2.61, 1.85).CalculateArea());
        }

        [TestMethod]
        public void NegativeSide()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-6.85, 7.902, 9.43).CalculateArea());
        }

        [TestMethod]
        public void TriangleDoesNotExist()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(12.105, 6.923, 25.128).CalculateArea());
        }

        [TestMethod]
        public void WholeSides()
        {
            Assert.AreEqual(132.816, new Triangle(23, 14, 19).CalculateArea());
        }

        [TestMethod]
        public void RightTriangle()
        {
            Assert.AreEqual(6, new Triangle(3, 4, 5).CalculateArea());
        }
    }
}
