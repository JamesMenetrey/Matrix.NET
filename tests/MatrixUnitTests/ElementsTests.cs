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
    }
}
