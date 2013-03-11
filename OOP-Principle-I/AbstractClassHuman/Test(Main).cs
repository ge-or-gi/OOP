using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define abstract class Human with first name and last name.
// Define new class Student which is derived from Human and has new field – grade.
// Define class Worker derived from Human with new property 
//      WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
// Define the proper constructors and properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.




namespace AbstractClassHuman
{
    class Test
    {
        static void Main(string[] args)
        {

            #region Students Init
            Student Pesho = new Student(3, "Pesho", "Peshev");
            Student Ivan = new Student(4, "Ivan", "Ivanov");
            Student Petyr = new Student(5, "Petyr", "Petrov");
            Student Dimo = new Student(3, "Dimo", "Dimov");
            Student Georgi = new Student(2, "Georgi", "Georgiev");
            Student Stefan = new Student(6, "Stefan", "Stefanov");
            Student Yana = new Student(6, "Yana", "Yaneva");
            Student Vanya = new Student(4, "Vanya", "Vaneva");
            Student Galya = new Student(4, "Galya", "Galeva");
            Student Katya = new Student(3, "Katya", "Kateva"); 
            #endregion

            #region Add Students to List
            List<Student> StudentList = new List<Student>();
            StudentList.Add(Pesho);
            StudentList.Add(Ivan);
            StudentList.Add(Petyr);
            StudentList.Add(Dimo);
            StudentList.Add(Georgi);
            StudentList.Add(Stefan);
            StudentList.Add(Yana);
            StudentList.Add(Vanya);
            StudentList.Add(Galya);
            StudentList.Add(Katya); 
            #endregion

            Console.WriteLine("Students List Order by Grade");
            Console.WriteLine();

            var OrderByStudentsByGrade = StudentList.OrderBy(x => x.Grade);
            foreach (var item in OrderByStudentsByGrade)
            {
                Console.WriteLine("{0} {1} : {2}", item.FirstName.ToString(), item.LastName.ToString(), item.Grade.ToString());
            }

            #region Workers Init
            Worker wk1 = new Worker(234, 8, "wk1", "wk1");
            Worker wk2 = new Worker(123, 8, "wk2", "wk2");
            Worker wk3 = new Worker(200, 5, "wk3", "wk3");
            Worker wk4 = new Worker(199, 7, "wk4", "wk4");
            Worker wk5 = new Worker(199, 6, "wk5", "WK5");
            Worker wk6 = new Worker(234, 7, "wk6", "wk6");
            Worker wk7 = new Worker(112, 6, "wk7", "wk7");
            Worker wk8 = new Worker(45, 3, "wk8", "wk8");
            Worker wk9 = new Worker(230, 1, "wk9", "wk9");
            Worker wk10 = new Worker(178, 8, "wk10", "wk10"); 
            #endregion

            #region Add Workers to List
            List<Worker> WorkersList = new List<Worker>();
            WorkersList.Add(wk1);
            WorkersList.Add(wk2);
            WorkersList.Add(wk3);
            WorkersList.Add(wk4);
            WorkersList.Add(wk5);
            WorkersList.Add(wk6);
            WorkersList.Add(wk7);
            WorkersList.Add(wk8);
            WorkersList.Add(wk9);
            WorkersList.Add(wk10); 
            #endregion

            Console.WriteLine();
            Console.WriteLine("Workers List Oredr By Hour Salary");
            Console.WriteLine();

            var OrederByWorkerByHourSalary = WorkersList.OrderByDescending( x => x.MoneyPerHour());

            foreach (var item in OrederByWorkerByHourSalary)
            {
                Console.WriteLine("{0} {1} : {2}", item.FirstName, item.LastName, item.MoneyPerHour().ToString("0.00", CultureInfo.InvariantCulture));
            }

            
            List<Human> HumansList = new List<Human>();

            HumansList.AddRange(StudentList);
            HumansList.AddRange(WorkersList);

            var OrderedHumansByName = HumansList.OrderBy(x => x.FirstName);

            Console.WriteLine();
            Console.WriteLine("Ordered List of Humans");
            Console.WriteLine();

            foreach (var item in OrderedHumansByName)
            {
                Console.WriteLine("{0} {1}", item.FirstName.ToString(), item.LastName.ToString());
            }

        }
    }
}
