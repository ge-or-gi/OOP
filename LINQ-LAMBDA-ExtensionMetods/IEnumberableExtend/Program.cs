using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement a set of extension methods for
//IEnumerable<T> that implement the following group functions:
//sum, product, min, max, average.


namespace IEnumberableExtend
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArr = new int[] { 5, 6, 2, 8, 5, 3, 8, 1, 9, 9, 3, 5, 9 };

            double[] decimalArr = new double[] { 0.1, 0.2, 0.5, 0.7 };

            string[] myStringArr = new string[] { "georgi", "petyr", "dimo", "ivan" };

            Console.WriteLine(myArr.Minimal());

            Console.WriteLine(myArr.Sum());

            Console.WriteLine(myStringArr.SumAll());

            Console.WriteLine(myArr.ProductEXT());

            Console.WriteLine(myArr.AverageAll());

            Console.WriteLine(decimalArr.SumAll());

            Console.WriteLine(decimalArr.AverageAll());

        }
    }
}
