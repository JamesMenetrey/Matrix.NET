using System;
using Binarysharp.Maths;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binarysharp.Tests
{
    [TestClass]
    public class InstantiationTests
    {
        [TestMethod]
        public void CreateIntegerMatrixWithArray()
        {
            // Arrange
            Matrix<int> matrix = null;
            var elements = new[,]
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };

            try
            {
                // Act
                matrix = new Matrix<int>(elements);
            }
            catch (Exception ex)
            {
                Assert.Fail("The matrix couldn't be created with valid array of integers. Details: {0}", ex);
            }

            Assert.IsNotNull(matrix);
        }

        [TestMethod]
        public void CreateIntegerMatrixWithDelegateBuilder()
        {
            // Arrange
            Matrix<int> matrix = null;
            Func<int, int, int> delegateBuilder = (i, j) => i == j ? 1 : 0;

            // Act

            try
            {
                matrix = new Matrix<int>(3, 3, delegateBuilder);
            }
            catch (Exception ex)
            {
                Assert.Fail("The matrix couldn't be created with a delegate builder. Details: {0}", ex);
            }

            // Assert
            Assert.IsNotNull(matrix);
        }
    }
}
