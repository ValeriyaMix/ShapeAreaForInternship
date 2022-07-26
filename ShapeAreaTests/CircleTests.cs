using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeAreaForInternship;

namespace ShapeAreaTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void DecimalRadius()
        {
            Assert.AreEqual(17.557, new Circle(2.364).CalculateArea());
        }

        [TestMethod]
        public void ZeroRadius()
        {
            Assert.AreEqual(0, new Circle(0).CalculateArea());
        }

        [TestMethod]
        public void NegativeRadius()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-7.85).CalculateArea());
        }

    }
}
