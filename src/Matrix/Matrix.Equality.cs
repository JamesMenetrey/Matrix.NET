using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarysharp.Maths
{
    public partial class Matrix<T>
    {

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((Matrix<T>)obj);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
        public bool Equals(Matrix<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return AreValuesOfMatricesEqual(this, other);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return _elements?.GetHashCode() ?? 0;
        }

        private bool AreValuesOfMatricesEqual(Matrix<T> left, Matrix<T> right)
        {
            if (left.NumberOfColumns != right.NumberOfColumns) return false;
            if (left.NumberOfRows != right.NumberOfRows) return false;

            for (int i = 0; i < left.NumberOfRows; i++)
            {
                for (int j = 0; j < left.NumberOfColumns; j++)
                {
                    if (!EqualityComparer<T>.Default.Equals(left[i, j], right[i, j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
