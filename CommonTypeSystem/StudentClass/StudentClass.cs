using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Define a class Student, which contains data about a student – first, middle and last name, SSN, 
        * permanent address, mobile phone e-mail, course, specialty, university, faculty. 
        * Use an enumeration for the specialties, universities and faculties. 
        * Override the standard methods, inherited by  System.Object: Equals(), ToString(), 
        * GetHashCode() and operators == and !=.
        *
        * 2.Add implementations of the ICloneable interface. 
        * The Clone() method should deeply copy all object's fields into a new object of type Student.
        * 
        * 3. Implement the  IComparable<Student> interface to compare students by names 
        * (as first criteria, in lexicographic order) and by social security number 
        * (as second criteria, in increasing order). 
 * */
namespace StudentClass
{
    class StudentClass
    {
        static void Main(string[] args)
        {


            Student firstStudent = new Student("Georgi", "Georgiev", "Georgiev", 123123, "SOme addres", "0898989", "some@some.com", University.TU, Faculty.Biology, Specialty.Biotechnology, 2);
            Student secondStudent = new Student("Galia", "Galeva", "Galeva", 234234, "other addres", "89898989", "other@some.com", University.Unspecified, Faculty.Unspecified, Specialty.Unspecified, 2);
            Student thirdStudent = new Student("Dimo", "Dimov", "Dimov", 345345, "sefcond addres", "7878787878", "second@some.com", University.SU, Faculty.Biology, Specialty.ComputerSystems, 3);
            Student forthStudent = new Student("Yana", "Yaneva", "Yaneva", 456456, "third addres", "456456456", "third@some.com", University.UNSS, Faculty.IT, Specialty.Chemistry, 1);
            Student fifthStudent = new Student("Vabya", "Vaneva", "Vaneva", 567567, "SOme addres", "0898989", "some@some.com", University.UNSS, Faculty.IT, Specialty.Unspecified, 3);


            
            // Test Equals()
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("First equals to Second : {0}", firstStudent.Equals(secondStudent));
            Console.WriteLine("Second equals to Second : {0}", secondStudent.Equals(secondStudent));
            Console.WriteLine("Third equals the Fifth: {0}", thirdStudent.Equals(fifthStudent));

            // Test opperators
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Tets == second to second : {0}", secondStudent == secondStudent );
            Console.WriteLine("Test == second to first : {0}", secondStudent == firstStudent);
            Console.WriteLine("Test == fifth to forth : {0}" , fifthStudent == forthStudent);

            // Test ToString()
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(firstStudent);
            Console.WriteLine(secondStudent);
            Console.WriteLine(forthStudent);

            // Test Cloning
            Console.WriteLine("--------------------------------------------------------");
            Student sixtStudent = (Student)firstStudent.Clone();
            Console.WriteLine(sixtStudent);
            Console.WriteLine(firstStudent);

            sixtStudent.FirstName = "Omurtag";
            firstStudent.FirstName = "Han";

            Console.WriteLine(sixtStudent);
            Console.WriteLine(firstStudent);


            // Test Compare To
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Compare First to Second {0}", firstStudent.CompareTo(secondStudent));
            Console.WriteLine("Compare Third to Third {0}", thirdStudent.CompareTo(thirdStudent));
            Console.WriteLine("Compare Sixt to First {0}", sixtStudent.CompareTo(firstStudent));


            Console.ReadKey();

        }
    }
}
