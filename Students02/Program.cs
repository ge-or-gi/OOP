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

            Students firstStudent = new Students();

            Students secondStudent = new Students("Georgi", "Georgiev");

            Students thirdStudent = new Students("Stefan", "Stefanov", "Stoyanov", Students.Year.Forth, Students.University.TUSofia, "Programing", "stefan@stoyanov.com", 0880880888);

            Console.WriteLine("Student Created {0}", Students.studenstCount);

            firstStudent.GetInfo();
            secondStudent.GetInfo();
            thirdStudent.GetInfo();

            //myStuden.FirstName = "Georgi";
            //myStuden.MiddleName = "Georgiev";
            //myStuden.LastName = "Mollov";
            //myStuden.EmailAddress = "georgi@georgi.com";
            //myStuden.IsStuding = "AIUT";
            //myStuden.PhoneNumber = 0878714643;

            //myStuden.IsInYear = Students.Year.First;
            //myStuden.IsInUniversity = Students.University.MGU;


            //Console.WriteLine(myStuden.IsInUniversity);




        }
    }
}
