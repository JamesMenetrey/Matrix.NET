using System;

namespace Binarysharp.Maths
{
    public partial class Matrix<T>
    {
        public T Determinant
        {
            get
            {
                if(NumberOfColumns != NumberOfRows) throw new ArithmeticException("The determinant couldn't be computed because this is not a square matrix.");

                return ComputeDeterminantOf2DArrays(_elements);
            }
        }

        private T ComputeDeterminantOf2DArrays(T[,] elements)
        {
            T determinant;

            if (elements.LongLength == 1)
            {
                if ((dynamic)elements[0, 0] < 0)
                {
                    determinant = (dynamic)elements[0, 0] * -1;
                }
                else
                {
                    determinant = elements[0, 0];
                }
            }
            else
            {
                throw new NotImplementedException();
            }
            
            return determinant;
        }
    }
}
