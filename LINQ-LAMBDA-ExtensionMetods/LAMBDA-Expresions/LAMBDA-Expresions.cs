using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using the extension methods OrderBy() and ThenBy() with lambda expressions 
//sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

namespace LINQ_Metod
{

    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int studentAge { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {


            Students[] studentsArr = new Students[]
            {
                new Students {FirstName = "Georgi", LastName="Mollov", studentAge = 33},
                new Students {FirstName = "Galina", LastName="Grueva", studentAge = 18},
                new Students {FirstName = "Dimo", LastName="Nyagolow", studentAge = 24},
                new Students {FirstName ="Yana", LastName="Stoyanova", studentAge = 20},
                new Students {FirstName="Hristina", LastName="Petrova", studentAge = 25},
                new Students {FirstName = "Georgi", LastName="Nakov", studentAge = 33}
            };

            Console.WriteLine();

            OrderByFirstName(studentsArr);

            Console.WriteLine();

            StudentsBtw18and24(studentsArr);

            Console.WriteLine();

            OrderByFirstAndLastNameDescendingLAMBDA(studentsArr);

            Console.WriteLine();

            OrderDescendingLINQ(studentsArr);

        }

        #region LINQ метод който подрежда студентите в нисходящ ред
        private static void OrderDescendingLINQ(Students[] studentsArr)
        {
            var orderDescending =
                from student in studentsArr
                orderby student.FirstName descending
                orderby student.LastName descending
                select student;
            foreach (Students item in orderDescending)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        } 
        #endregion

        #region LAMBDA метод който подрежда по първо и после по второ име ако има две еднакви първи имена
        private static void OrderByFirstAndLastNameDescendingLAMBDA(Students[] studentsArr)
        {
            var OrderedStudentsLAMBDA = studentsArr.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var item in OrderedStudentsLAMBDA)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        } 
        #endregion

        #region LINQ метод който показва всички между 18 и 24 години
        private static void StudentsBtw18and24(Students[] studentsArr)
        {
            var queryResult =
                from student in studentsArr
                where student.studentAge >= 18 && student.studentAge <= 24
                select student;

            foreach (Students item in queryResult)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
        #endregion

        #region LINQ метод който сравнява дали Първото име е по Голямо от Фамилията
        private static void OrderByFirstName(Students[] studentsArr)
        {
            var quryResult =
                from student in studentsArr
                where (student.FirstName.CompareTo(student.LastName) < 0)
                select student;

            foreach (Students item in quryResult)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
        #endregion
    }
}
