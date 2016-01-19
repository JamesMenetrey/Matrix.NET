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
    }
}
