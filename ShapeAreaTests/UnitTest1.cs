using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeAreaForInternship;

namespace ShapeAreaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProperCalculateAreaCircle()
        {
            Assert.AreEqual(17.557, new Circle(2.364).CalculateArea());
        }

        [TestMethod]
        public void ProperCalculateAreaTriangle()
        {
            Assert.AreEqual(2.342, new Triangle(3.547, 2.61, 1.85).CalculateArea());
        }

        [TestMethod]
        public void ThrowExeptionNegativeRadiusCircle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-7.85).CalculateArea());
        }

        [TestMethod]
        public void ThrowExeptionNegativeSideTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-6.85, 7.902, 9.43).CalculateArea());
        }

        [TestMethod]
        public void ThrowExeptionTriangleDoesNotExist()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(12.105, 6.923, 25.128).CalculateArea());
        }
    }
}
