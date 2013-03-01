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
    public static class Extension
    {

        public static T SumAll<T>(this IEnumerable<T> stufToSum)
        {
            dynamic sum = 0;

           

                foreach (var item in stufToSum)
                {
                    sum += (dynamic)item;
                }

                return sum;
                   
        }

        public static T Minimal<T>(this IEnumerable<T> someStuf) where T: IComparable<T>
        {
            dynamic minValue = someStuf.First();

            foreach (var item in someStuf)
            {

                if (minValue.CompareTo(item) > 0)
                {
                    minValue = item;
                }

            }

            return minValue;
            
        }

        public static T Maximal<T>(this IEnumerable<T> someStuf) where T : IComparable<T>
        {
            dynamic maxValue = someStuf.First();

            foreach (var item in someStuf)
            {
                if (maxValue.CompareTo(item) < 0)
                {
                    maxValue = item;
                }

            }

            return maxValue;
        
        
        }

        public static T ProductEXT<T>(this IEnumerable<T> someStuf)
        {
            dynamic product = 1;

            foreach (var item in someStuf)
            {
                product *= item;
            }

            return product;
        
        }

        public static T AverageAll<T>(this IEnumerable<T> someStuf)
        {
            dynamic result = 0;

            foreach (var item in someStuf)
            {

                result += item;


            }

            result = result / someStuf.Count();

            return result;
        
        
        }

    }
}
