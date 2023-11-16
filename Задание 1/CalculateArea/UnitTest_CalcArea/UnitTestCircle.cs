using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculateArea;

namespace UnitTest_CalcArea
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void CircleTestTrueResult()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
