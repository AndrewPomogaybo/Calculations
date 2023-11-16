using CalculateArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_CalcArea
{
    [TestClass]
    public class UnitTestIsRightTriangle
    {
        [TestMethod]
        public void TestMethodTrueResult()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }
    }
}
