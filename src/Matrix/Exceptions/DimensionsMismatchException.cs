using System;

namespace Binarysharp.Maths.Exceptions
{
    /// <summary>
    /// An exception that indicates a mismatch between the dimension of two matrices.
    /// </summary>
    /// <typeparam name="T">The data type of the matrices.</typeparam>
    public class DimensionsMismatchException<T> : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionsMismatchException{T}"/> class.
        /// </summary>
        /// <param name="left">The first matrix.</param>
        /// <param name="right">The second matrix.</param>
        public DimensionsMismatchException(Matrix<T> left, Matrix<T> right)
            : base(
                $"The matrices have have a different dimension (left {left.NumberOfRows}x{left.NumberOfColumns}; right {right.NumberOfRows}x{right.NumberOfColumns})."
                )
        {
        }
    }
}
