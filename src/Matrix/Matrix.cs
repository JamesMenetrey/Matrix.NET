/*
    A .NET implementation of matrices and their operations.
    https://github.com/ZenLulz/Matrix.NET

    This project is under MIT license.
    Created by Jämes Ménétrey.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Binarysharp.Maths
{
    /// <summary>
    /// Represents an immutable matrix data type.
    /// </summary>
    public class Matrix<T>
    {
        /// <summary>
        /// The values of the matrix.
        /// </summary>
        private T[,] _values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix{T}"/> class with a multidimensional array of values.
        /// </summary>
        /// <param name="values">The values of the matrix.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The matrix cannot be empty.
        /// or
        /// The structure of the matrix is unbalanced.
        /// </exception>
        public Matrix(T[,] values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            if (values.Length == 0) throw new ArgumentOutOfRangeException(nameof(values), "The matrix cannot be empty.");

            _values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix{T}"/> class using a builder method that provides values.
        /// </summary>
        /// <param name="rowNumber">The number of rows of the matrix.</param>
        /// <param name="columnNumber">The number of columns of the matrix.</param>
        /// <param name="builder">A method that builds the values.
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

            _values = CreateValueArrayFromBuilder(rowNumber, columnNumber, builder);
        }

        /// <summary>
        /// Creates a multidimensional array using a builder method.
        /// </summary>
        /// <param name="rowNumber">The row number.</param>
        /// <param name="columnNumber">The column number.</param>
        /// <param name="builder">A method that builds the values.
        /// The first parameter is the identifier of the row and the second one is the identifier of the column.
        /// </param>
        /// <returns>The return value is a multidimensional array of the values.</returns>
        private T[,] CreateValueArrayFromBuilder(int rowNumber, int columnNumber, Func<int, int, T> builder)
        {
            var values = new T[rowNumber, columnNumber];

            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    values[i, j] = builder(i, j);
                }
            }

            return values;
        }
    }
}
