namespace Binarysharp.Maths
{
    public partial class Matrix<T>
    {
        /// <summary>
        /// Multiplies a matrix with a scalar value.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="scalar">The scalar value.</param>
        /// <returns>The return value is the multiplication of the matrix and the scalar value.</returns>
        public static Matrix<T> operator *(Matrix<T> matrix, T scalar)
        {
            var elements = new T[matrix.NumberOfRows, matrix.NumberOfColumns];

            for (int i = 0; i < matrix.NumberOfRows; i++)
            {
                for (int j = 0; j < matrix.NumberOfColumns; j++)
                {
                    elements[i, j] = (dynamic)matrix[i, j] * scalar;
                }
            }

            return new Matrix<T>(elements);
        } 
    }
}
