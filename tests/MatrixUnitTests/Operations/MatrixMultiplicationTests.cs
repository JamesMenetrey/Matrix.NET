using System;
using Binarysharp.Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests.Operations
{
    [TestClass]
    public class MatrixMultiplicationTests
    {
        [TestMethod]
        public void Multiply2X2And2X3()
        {
            // Arrange
            var left = new Matrix<int>(new[,]
            {
                {2, 1 },
                {0, -1 }
            });
            var right = new Matrix<int>(new[,]
            {
                {1, 0, 3},
                {-1, 1, 0 }
            });

            var expected = new Matrix<int>(new[,]
            {
                {1, 1, 6},
                {1, -1, 0 }
            });

            // Act
            var result = left * right;

            // Assert
            Assert.IsTrue(expected == result, "The result of the multiplication does not match with the expected result.");
        }

        [TestMethod]
        public void Multiply3X3And3X3()
        {
            // Arrange
            var matrix = new Matrix<int>(new[,]
            {
                {-1, 2, 3 },
                {4, -5, 6 },
                {7, 8, -9 }
            });

            var expected = new Matrix<int>(new[,]
            {
                {30, 12, -18},
                {18, 81, -72 },
                {-38, -98, 150 }
            });

            // Act
            var result = matrix * matrix;

            // Assert
            Assert.IsTrue(expected == result, "The result of the multiplication does not match with the expected result.");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException), "Incorrect dimensions for a matrix multiplication.")]
        public void Multiplay3X2And3X2()
        {
            // Arrange
            var matrix = new Matrix<int>(new[,]
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            });

            // Act
            Func<Matrix<int>> multiply = () => matrix * matrix;
            multiply();
        }
    }
}
