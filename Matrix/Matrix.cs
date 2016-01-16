using System;
using System.Linq;

namespace Binarysharp.Maths
{
    /// <summary>
    /// Represents an immutable matrix data type.
    /// </summary>
    public class Matrix<T>
    {
        private T[][] _values;

        public Matrix(T[][] values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            if (values.Length == 0) throw new ArgumentOutOfRangeException(nameof(values), "The matrix cannot be empty.");
            if (!AreValuesProperlyBalanced(values)) throw new ArgumentOutOfRangeException(nameof(values), "The structure of the matrix is unbalanced.");

            _values = values;
        }

        private bool AreValuesProperlyBalanced(T[][] values)
        {
            return values.All(value => value.Length == values[0].Length);
        }
    }
}
