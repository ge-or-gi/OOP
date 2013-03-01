﻿using System;
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
                new Students {FirstName="Hristina", LastName="Petrova", studentAge = 25}
            };


            OrderByFirstName(studentsArr);

            Console.WriteLine();

            StudentsBtw18and24(studentsArr);




        }

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
