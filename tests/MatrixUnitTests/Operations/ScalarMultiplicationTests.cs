using System;
using Binarysharp.Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests.Operations
{
    [TestClass]
    public class ScalarMultiplicationTests
    {
        [TestMethod]
        public void MultiplyByTwo()
        {
            // Arrange
            var matrix = new Matrix<int>(new[,]
            {
                {2, -1 },
                {3, 0 }
            });
            
            var expected = new Matrix<int>(new int[,]
            {
                {4, -2 },
                {6, 0 }
            });

            // Act
            var result = matrix * 2;

            // Assert
            Assert.IsTrue(expected == result, "The result of the multiplication does not match with the expected result.");
        }
    }
}
