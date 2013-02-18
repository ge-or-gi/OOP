using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Students myStuden = new Students();

            myStuden.FirstName = "Georgi";
            myStuden.MiddleName = "Georgiev";
            myStuden.LastName = "Mollov";
            myStuden.EmailAddress = "georgi@georgi.com";
            myStuden.IsStuding = "AIUT";
            myStuden.PhoneNumber = 0878714643;

            myStuden.IsInYear = Students.Year.First;
            myStuden.IsInUniversity = Students.University.MGU;


            Console.WriteLine(myStuden.IsInUniversity);




        }
    }
}
