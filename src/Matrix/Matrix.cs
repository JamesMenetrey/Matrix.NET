/*
    A .NET implementation of matrices and their operations.
    https://github.com/ZenLulz/Matrix.NET

    This project is under MIT license.
    Created by Jämes Ménétrey.
*/

using System;

namespace Binarysharp.Maths
{
    /// <summary>
    /// Represents an immutable matrix data type.
    /// </summary>
    public partial class Matrix<T>
    {
        /// <summary>
        /// The elements of the matrix.
        /// </summary>
        private readonly T[,] _elements;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix{T}"/> class with a multidimensional array of elements.
        /// </summary>
        /// <param name="elements">The elements of the matrix.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The matrix cannot be empty.
        /// or
        /// The structure of the matrix is unbalanced.
        /// </exception>
        public Matrix(T[,] elements)
        {
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            if (elements.Length == 0) throw new ArgumentOutOfRangeException(nameof(elements), "The matrix cannot be empty.");

            _elements = elements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix{T}"/> class using a builder method that provides elements.
        /// </summary>
        /// <param name="rowNumber">The number of rows of the matrix.</param>
        /// <param name="columnNumber">The number of columns of the matrix.</param>
        /// <param name="builder">A method that builds the elements.
        /// The first parameter is the identifier of the row and the second one is the identifier of the column.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The number of rows must be above 0.
        /// or
        /// The number of columns must be above 0.
        /// </exception>
        /// <exception cref="System.ArgumentNullException"></exception>
        public Matrix(int rowNumber, int columnNumber, Func<int, int, T> builder)
        {
            if (rowNumber <= 0) throw new ArgumentOutOfRangeException(nameof(rowNumber), "The number of rows must be above 0.");
            if (columnNumber <= 0) throw new ArgumentOutOfRangeException(nameof(rowNumber), "The number of columns must be above 0.");
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            _elements = CreateElementsArrayFromBuilder(rowNumber, columnNumber, builder);
        }

        /// <summary>
        /// Creates a multidimensional array using a builder method.
        /// </summary>
        /// <param name="rowNumber">The row number.</param>
        /// <param name="columnNumber">The column number.</param>
        /// <param name="builder">A method that builds the elements.
        /// The first parameter is the identifier of the row and the second one is the identifier of the column.
        /// </param>
        /// <returns>The return value is a multidimensional array of elements.</returns>
        private T[,] CreateElementsArrayFromBuilder(int rowNumber, int columnNumber, Func<int, int, T> builder)
        {
            var elements = new T[rowNumber, columnNumber];

            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    elements[i, j] = builder(i, j);
                }
            }

            return elements;
        }
    }
}
