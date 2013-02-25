using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGenerics
{
    public class Matrix<T>
    {

        private T[,] _matrix;
        
        private int row, col;

        public int Col
        {
            get { return col; }
            //set { col = value; }
        }

        public int Row
        {
            get { return row; }
            //set { row = value; }
        }



        // създаване на матрицата със стойности по подразбиране 5
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            _matrix = new T[row, col];
        }

        // индексиране на матрицата
        public T this[int i, int j]
        {
            get 
            {
                if (ChekIfIndexIsInRange(i, j))
                {
                    ThrowExeption();
                    return default(T);
                }
                else
                {
                    T result = _matrix[i, j];
                    return result;
                }
            }

            set
            {
                if (ChekIfIndexIsInRange(i,j))
                {
                    ThrowExeption();
                }
                else
                {
                    _matrix[i, j] = value;
                }
            }
        
        
        }

        //метод за хвърляне на гршка за да избегнем повторенията
        private static void ThrowExeption()
        {
            throw new IndexOutOfRangeException("Out of range of the MATRIX");
        }

        //метод за проверка по индекса за да избегнем повторенията
        private bool ChekIfIndexIsInRange(int i, int j)
        {
            return i > _matrix.GetLength(0) || j > _matrix.GetLength(1) || i < 0 || j < 0;
        }

        //събиране на матриците
        public static Matrix<T> operator +(Matrix<T> mtrx1, Matrix<T> mtrx2)
        {
            Matrix<T> newMatrix = new Matrix<T>(mtrx1.Row, mtrx1.Col);

            for (int row = 0; row < mtrx1.Row; row++)
            {

                for (int col = 0; col < mtrx2.Col; col++)
                {

                    newMatrix[row, col] = (dynamic)mtrx1[row, col] + (dynamic)mtrx2[row, col];
                }
            }

            return newMatrix;

        }
        //изваждане на матриците
        public static Matrix<T> operator -(Matrix<T> mtrx1, Matrix<T> mtrx2)
        {
            Matrix<T> newMatrix = new Matrix<T>(mtrx1.Row, mtrx1.Col);

            for (int row = 0; row < mtrx1.Row; row++)
            {

                for (int col = 0; col < mtrx2.Col; col++)
                {

                    newMatrix[row, col] = (dynamic)mtrx1[row, col] - (dynamic)mtrx2[row, col];
                }
            }

            return newMatrix;

        }

        public static Matrix<T> operator *(Matrix<T> mtrx1, Matrix<T> mtrx2)
        {
            if (mtrx1.Col != mtrx2.Row)
            {
                throw new FormatException("? ");
            }
            else
            {
                int row = mtrx1.Row;
                int col = mtrx2.Col;
                Matrix<T> newMatrix = new Matrix<T>(row, col);

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        dynamic sum = 0;
                        for (int x = 0; x < col; x++)
                        {
                            sum = sum + (dynamic)mtrx1._matrix[i, x] * (dynamic)mtrx2._matrix[x, j];
                        }
                        newMatrix._matrix[i, j] = sum;
                    }
                }

                return newMatrix;
            }
        }





    }
}
