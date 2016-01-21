using System;
using System.Runtime.InteropServices;

namespace Binarysharp.Maths
{
    public partial class Matrix<T>
    {
        public static Matrix<T> operator *(Matrix<T> left, Matrix<T> right)
        {
            if (left.NumberOfColumns != right.NumberOfRows) throw new ArgumentException("Cannot multiply two matrices where the number of columns of the first doesn't match the number of rows of the second.");

            return MultiplyTwoMatrices(left, right);
        }

        private static Matrix<T> MultiplyTwoMatrices(Matrix<T> left, Matrix<T> right)
        {
            var elements = new T[left.NumberOfRows, right.NumberOfColumns];

            for (int i = 0; i < left.NumberOfRows; i++)
            {
                for (int j = 0; j < right.NumberOfColumns; j++)
                {
                    elements[i, j] = ComputeOneElementForMatrixProduct(left, right, i, j);
                }
            }

			return new Matrix<T>(elements);
        }

        private static T ComputeOneElementForMatrixProduct(Matrix<T> left, Matrix<T> right, int i, int j)
        {
            T element = (dynamic)left[i, 0] * (dynamic)right[0, j];

            for (int index = 1; index < left.NumberOfColumns; index++)
            {
                element += (dynamic)left[i, index] * (dynamic)right[index, j];
            }

			return element;
        }
    }
}
