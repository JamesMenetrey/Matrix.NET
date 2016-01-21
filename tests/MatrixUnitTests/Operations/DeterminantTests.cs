using System;
using Binarysharp.Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests.Operations
{
    [TestClass]
    public class DeterminantTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException), "Computing a determinant from a non-square matrix is not allowed.")]
        public void NotSquareMatrix()
        {
            // Arrange
            var matrix = new Matrix<int>(new[,] { { 0, 1 } });

            // Act
            Func<int> getDeterminant = () => matrix.Determinant;
            getDeterminant();
        }

        [TestMethod]
        public void ComputePositiveFor1X1()
        {
            // Arrange
            var matrix = new Matrix<int>(new[,] { { 5 } });

            // Act
            var determinant = matrix.Determinant;

            // Assert
            Assert.AreEqual(5, determinant);
        }


        [TestMethod]
        public void ComputeNegativeFor1X1()
        {
            // Arrange
            var matrix = new Matrix<int>(new[,] { { -5 } });

            // Act
            var determinant = matrix.Determinant;

            // Assert
            Assert.AreEqual(5, determinant);
        }
    }
}
