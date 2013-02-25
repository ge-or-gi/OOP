﻿/*
 * Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
 * Implement an indexer this[row, col] to access the inner matrix cells.
 * Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
 * Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            Matrix<int> myFirstMatrix = new Matrix<int>(2,2);
            Matrix<int> mySecondMatrix = new Matrix<int>(2, 2);

            myFirstMatrix[0, 0] = 10;
            myFirstMatrix[0, 1] = 10;
            //myFirstMatrix[0, 2] = 10;
            myFirstMatrix[1, 0] = 10;
            myFirstMatrix[1, 1] = 10;
            //myFirstMatrix[1, 2] = 10;
            //myFirstMatrix[2, 0] = 10;
            //myFirstMatrix[2, 1] = 10;
            //myFirstMatrix[2, 2] = 10;

            mySecondMatrix[0, 0] = 10;
            mySecondMatrix[0, 1] = 10;
            //mySecondMatrix[0, 2] = 10;
            mySecondMatrix[1, 0] = 10;
            mySecondMatrix[1, 1] = 10;
            //mySecondMatrix[1, 2] = 10;
            //mySecondMatrix[2, 0] = 10;
            //mySecondMatrix[2, 1] = 10;
            //mySecondMatrix[2, 2] = 10;

            Matrix<int> myThirdMatrix = new Matrix<int>(2, 2);

            myThirdMatrix = myFirstMatrix + mySecondMatrix;

            myThirdMatrix = myFirstMatrix * mySecondMatrix;




        }
    }
}
