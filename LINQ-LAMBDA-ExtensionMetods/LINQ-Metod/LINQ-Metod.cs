using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that from a given array of students
//finds all students whose first name is before its
//last name alphabetically. Use LINQ query operators.


namespace LINQ_Metod
{

    public class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {


            Students[] studentsArr = new Students[]
            {
                new Students {firstName = "Georgi", lastName="Mollov"},
                new Students {firstName = "Galina", lastName="Grueva"},
                new Students {firstName = "Dimo", lastName="Nyagolow"},
                new Students {firstName ="Yana", lastName="Stoyanova"},
                new Students {firstName="Hristina", lastName="Petrova"}
            };


            OrderByFirstName(studentsArr);

        }

        private static void OrderByFirstName(Students[] studentsArr)
        {
            var quryResult =
                from student in studentsArr
                where (student.firstName.CompareTo(student.lastName) < 0)
                select student;

            foreach (Students item in quryResult)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }
        }
    }
}
