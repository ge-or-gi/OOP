using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    /*
     * Define a class InvalidRangeException<T> that holds information about an error
     * condition related to invalid range. It should hold error message and a range definition [start … end].
     * Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
     * by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
     */


    static void PrintNumber(int number)
    {

        int min = 0;
        int max = 100;

        if (number > max || number <min)
        {
            string someMessage = String.Format("The number must be in betwin");
            throw new InvalidDataRangeExeption<int>(someMessage, min, max);
        }
        else
        {
            Console.WriteLine(number);
        }


    }

    static void PrintDate(DateTime date)
    {
        DateTime minDate = new DateTime(1980, 1, 1);
        DateTime maxDate = new DateTime(2013, 12, 31);

        if (date > maxDate || date < minDate)
        {
            string someMessage = String.Format("The date must be in betwin");
            throw new InvalidDataRangeExeption<DateTime>(someMessage, minDate, maxDate);
        }
        else
        {
            Console.WriteLine(date.ToShortDateString());
        }

    }

    static void Main()
    {
         
            PrintNumber(6);
            PrintDate(new DateTime(1985, 1, 1));
        
    }
}
