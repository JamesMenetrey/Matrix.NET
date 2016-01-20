using System;
using Binarysharp.Maths.Exceptions;

namespace Binarysharp.Maths
{
    /// <summary>
    /// Represents an immutable matrix data type.
    /// </summary>
    public partial class Matrix<T>
    {
        public static Matrix<T> operator +(Matrix<T> left, Matrix<T> right)
        {
            if (left.NumberOfRows != right.NumberOfRows) throw new DimensionsMismatchException<T>(left, right);
            if (left.NumberOfColumns != right.NumberOfColumns) throw new DimensionsMismatchException<T>(left, right);


            return SumTwoMatrices(left, right);
        }

        private static Matrix<T> SumTwoMatrices(Matrix<T> left, Matrix<T> right)
        {
            var elements = new T[left.NumberOfRows, left.NumberOfColumns];

            for (int i = 0; i < left.NumberOfRows; i++)
            {
                for (int j = 0; j < left.NumberOfColumns; j++)
                {
                    elements[i, j] = (dynamic)left[i, j] + (dynamic)right[i, j];
                }
            }

            return new Matrix<T>(elements);
        }
    }
}
