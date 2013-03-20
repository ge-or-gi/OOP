using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Person with two fields – name and age. Age can be
//left unspecified (may contain null value. Override ToString() to 
//display the information of a person and if age is not specified – 
//to say so. Write a program to test this functionality.

//Create two persons and print their names and ages

namespace PersonNullAge
{
    class PersonNullAge
    {
        static void Main(string[] args)
        {

            
            Person firstPerson = new Person("Georgi", 27);
            Person secondPerson = new Person("Stefan");
            Person thirdPerson = new Person("Galia");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine(thirdPerson);

        }
    }
}
