/*
    A .NET implementation of matrices and their operations.
    https://github.com/ZenLulz/Matrix.NET

    This project is under MIT license.
    Created by Jämes Ménétrey.
*/

using System;
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
        private T[][] _values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix{T}"/> class with a set of values.
        /// </summary>
        /// <param name="values">The values of the matrix.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The matrix cannot be empty.
        /// or
        /// The structure of the matrix is unbalanced.
        /// </exception>
        public Matrix(T[][] values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            if (values.Length == 0) throw new ArgumentOutOfRangeException(nameof(values), "The matrix cannot be empty.");
            if (!AreValuesProperlyBalanced(values)) throw new ArgumentOutOfRangeException(nameof(values), "The structure of the matrix is unbalanced.");

            _values = values;
        }

        /// <summary>
        /// Indicates whether the values properly balanced.
        /// </summary>
        /// <param name="values">The values of the matrix.</param>
        /// <returns><c>true</c> if properly balanced, <c>false</c> otherwise.</returns>
        private bool AreValuesProperlyBalanced(T[][] values)
        {
            return values.All(value => value.Length == values[0].Length);
        }
    }
}
