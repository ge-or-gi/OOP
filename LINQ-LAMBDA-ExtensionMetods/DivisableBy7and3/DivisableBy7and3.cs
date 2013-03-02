using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints from given array 
//of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions.
//Rewrite the same with LINQ.


namespace DivisableBy7and3
{
    class DivisableBy7and3
    {
        static void Main(string[] args)
        {

            int[] intArr = new int[] { 2, 21, 3, 7, 42, 10 };


            #region LAMBDA проверка за деление на 7 и 3
            var LAMBDAresult = intArr.Where(x => x % 21 == 0);

            foreach (var item in LAMBDAresult)
            {
                Console.WriteLine(item);
            } 
            #endregion

            Console.WriteLine();

            #region LINQ проверка за целочислено деление на 7 и 3
            var LINQresult =
                    from number in intArr
                    where number % 3 == 0 && number % 7 == 0
                    select number;

            foreach (var item in LINQresult)
            {
                Console.WriteLine(item);
            } 
            #endregion

        }
    }
}
