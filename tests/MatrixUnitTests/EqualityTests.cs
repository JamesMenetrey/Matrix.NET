using System;
using Binarysharp.Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests
{
    [TestClass]
    public class EqualityTests
    {
        [TestMethod]
        public void EqualityWithIEquatableInterface()
        {
            // Arrange
            IEquatable<Matrix<int>> leftMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));
            var rightMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));

            // Act
            var areEqual = leftMatrix.Equals(rightMatrix);

            // Assert
            Assert.IsTrue(areEqual, "The two matrices have the same elements and must be equal.");
        }

        [TestMethod]
        public void EqualityWithObjectEqualMethod()
        {
            // Arrange
            object leftMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));
            var rightMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));

            // Act
            var areEqual = leftMatrix.Equals(rightMatrix);

            // Assert
            Assert.IsTrue(areEqual, "The two matrices have the same elements and must be equal.");
        }

        [TestMethod]
        public void EqualityWithOperators()
        {
            // Arrange
            var leftMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));
            var rightMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));

            // Act
            var areEqual = leftMatrix == rightMatrix;
            var areNotEqual = leftMatrix != rightMatrix;

            // Assert
            Assert.IsTrue(areEqual, "The two matrices have the same elements and must be equal.");
            Assert.IsFalse(areNotEqual, "The two matrices have the same elements and must be equal.");
        }

        [TestMethod]
        public void InequalityForDifferentColumnSizeMatrices()
        {
            // Arrange
            var leftMatrix = new Matrix<int>(3, 2, (i, j) => MatrixBuilder(i, j, 1));
            var rightMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));

            // Act
            var areEqual = leftMatrix == rightMatrix;

            // Assert
            Assert.IsFalse(areEqual, "The two matrices have a different size.");
        }

        [TestMethod]
        public void InequalityForDifferentRowSizeMatrices()
        {
            // Arrange
            var leftMatrix = new Matrix<int>(2, 3, (i, j) => MatrixBuilder(i, j, 1));
            var rightMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));

            // Act
            var areEqual = leftMatrix == rightMatrix;

            // Assert
            Assert.IsFalse(areEqual, "The two matrices have a different size.");
        }

        [TestMethod]
        public void InequalityForDifferentElements()
        {
            // Arrange
            var leftMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 1));
            var rightMatrix = new Matrix<int>(3, 3, (i, j) => MatrixBuilder(i, j, 2));

            // Act
            var areEqual = leftMatrix == rightMatrix;

            // Assert
            Assert.IsFalse(areEqual, "The two matrices have different elements.");
        }

        private int MatrixBuilder(int i, int j, int modifier)
        {
            var value = i == j ? 1 : 0;
            return value * modifier;
        }
    }
}
