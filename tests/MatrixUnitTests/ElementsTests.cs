using System;
using Binarysharp.Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests
{
    [TestClass]
    public class ElementsTests
    {
        [TestMethod]
        public void AccessTheElements()
        {
            // Arrange
            var predefinedElements = new[,]
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };

            // Act
            var matrix = new Matrix<int>(predefinedElements);

            // Assert
            for (int i = 0; i < predefinedElements.GetLength(0); i++)
            {
                for (int j = 0; j < predefinedElements.GetLength(1); j++)
                {
                    Assert.AreEqual(predefinedElements[i, j], matrix[i, j], "An element is not equal to the original value used to create the matrix.");
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "Accessing an element ouside of the matrix must throw an exception.")]
        public void AccessToOutOfRangeElements()
        {
            // Arrange
            var element = new[,] { { 0 } };

            // Act
            var matrix = new Matrix<int>(element);
            Func<int> accessToInvalidIndex = () => matrix[element.GetLength(0) + 1, element.GetLength(1) + 1];

            accessToInvalidIndex();
        }

        [TestMethod]
        public void NumberOfRowsFor2X2()
        {
            // Arrange
            var predefinedElements = new[,]
            {
                {1, 0},
                {0, 1}
            };

            // Act
            var matrix = new Matrix<int>(predefinedElements);

            // Assert
            Assert.AreEqual(2, matrix.NumberOfRows);
            Assert.AreEqual(2, matrix.NumberOfColumns);
        }

        [TestMethod]
        public void NumberOfRowsFor3X2()
        {
            // Arrange
            var predefinedElements = new[,]
            {
                {1, 0},
                {0, 1},
                {0, 0}
            };

            // Act
            var matrix = new Matrix<int>(predefinedElements);

            // Assert
            Assert.AreEqual(3, matrix.NumberOfRows);
            Assert.AreEqual(2, matrix.NumberOfColumns);
        }

        [TestMethod]
        public void NumberOfRowsFor3X3()
        {
            // Arrange
            var predefinedElements = new[,]
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };

            // Act
            var matrix = new Matrix<int>(predefinedElements);

            // Assert
            Assert.AreEqual(3, matrix.NumberOfRows);
            Assert.AreEqual(3, matrix.NumberOfColumns);
        }
    }
}
