using CalculateArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_CalcArea
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestMethodTriangleTrueResult()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea);
        }
    }
}
