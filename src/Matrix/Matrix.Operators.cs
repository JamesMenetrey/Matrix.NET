namespace Binarysharp.Maths
{
    /// <summary>
    /// Represents an immutable matrix data type.
    /// </summary>
    public partial class Matrix<T>
    {
        /// <summary>
        /// Gets the element of type <see cref="T"/> at i and j index.
        /// </summary>
        /// <param name="i">The row index.</param>
        /// <param name="j">The column index.</param>
        /// <returns>T.</returns>
        public T this[int i, int j] => _elements[i, j];

        /// <summary>
        /// Compares two matrices and returns <c>true</c> if the matrices are equal, <c>false</c> otherwise.
        /// </summary>
        /// <param name="left">The left matrix.</param>
        /// <param name="right">The right matrix.</param>
        /// <returns>The return value is <c>true</c> if the matrices are equal, <c>false</c> otherwise.</returns>
        public static bool operator ==(Matrix<T> left, Matrix<T> right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Compares two matrices and returns <c>true</c> if the matrices are different, <c>false</c> otherwise.
        /// </summary>
        /// <param name="left">The left matrix.</param>
        /// <param name="right">The right matrix.</param>
        /// <returns>The return value is <c>true</c> if the matrices are different, <c>false</c> otherwise.</returns>
        public static bool operator !=(Matrix<T> left, Matrix<T> right)
        {
            return !Equals(left, right);
        }
    }
}
