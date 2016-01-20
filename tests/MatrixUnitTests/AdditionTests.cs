using System;
using Binarysharp.Maths;
using Binarysharp.Maths.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void SumTwoMatricesWithSameSize()
        {
            // Arrange
            var left = new Matrix<int>(new[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            });

            var right = new Matrix<int>(new[,]
            {
                {8, -1, 3 },
                {2, -4, 1 },
                {-4, 2, 9 }
            });
            var expected = new Matrix<int>(new[,]
            {
                {9, 1, 6 },
                {6, 1, 7 },
                {3, 10, 18 }
            });

            // Act
            var sum = left + right;

            // Assert
            Assert.IsTrue(expected == sum, "The sum of the matrices does not match with the expected result.");
        }

        [TestMethod]
        [ExpectedException(typeof(DimensionsMismatchException<int>), "The two matrices cannot be additioned because they don't have the same size.")]
        public void SumTwoMatricesWithDifferentRowSize()
        {
            // Arrange
            var left = new Matrix<int>(new[,]
            {
                {1, 2, 3 },
                {4, 5, 6 }
            });

            var right = new Matrix<int>(new[,]
            {
                {8, -1, 3 },
                {2, -4, 1 },
                {-4, 2, 9 }
            });

            // Act
            Func<Matrix<int>> computeSum = () => left + right;
            computeSum();
        }

        [TestMethod]
        [ExpectedException(typeof(DimensionsMismatchException<int>), "The two matrices cannot be additioned because they don't have the same size.")]
        public void SumTwoMatricesWithDifferentColumnSize()
        {
            // Arrange
            var left = new Matrix<int>(new[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            });

            var right = new Matrix<int>(new[,]
            {
                {8, -1 },
                {2, -4 },
                {-4, 2 }
            });

            // Act
            Func<Matrix<int>> computeSum = () => left + right;
            computeSum();
        }
    }
}
