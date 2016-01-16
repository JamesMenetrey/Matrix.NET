using System;
using Binarysharp.Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests
{
    [TestClass]
    public class InstantiationTests
    {
        [TestMethod]
        public void CreateMatrixWithIntegerArrays()
        {
            // Arrange
            Matrix<int> matrix = null;
            var values = new[]
            {
                new[] {1, 0, 0},
                new[] {0, 1, 0},
                new[] {0, 0, 1}
            };

            try
            {
                // Act
                matrix = new Matrix<int>(values);
            }
            catch (Exception ex)
            {
                Assert.Fail("The matrix couldn't be created with valid arrays of integers. {0}", ex);
            }

            Assert.IsNotNull(matrix);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The matrix cannot be created with an unbalanced number of values.")]
        public void CreateMatrixWithUnbalancedValues()
        {
            // Arrange
            var values = new[]
            {
                new[] {1, 0, 0},
                new[] {0, 1, 0},
                new[] {0, 1}
            };

            // Act
            var matrix = new Matrix<int>(values);

            // Assert
            Assert.IsNotNull(matrix);
        }
    }
}
