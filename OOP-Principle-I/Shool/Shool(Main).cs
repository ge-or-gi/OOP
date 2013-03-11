using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We are given a school. In the school there are classes of students. Each class has a set of teachers.
// Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. 
// Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
// Students, classes, teachers and disciplines could have optional comments (free text block).
// Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
// encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.


namespace Shool
{
    class Shool
    {
        static void Main(string[] args)
        {

            

            Student GeorgiMollov = new Student(123, "Georgi", "Mollov");
            Student PetyrIvanov = new Student(124, "Petyr", "Ivanov");
            Student DimoNyagolov = new Student(125, "Dimo", "Nyagolov");
            Student YanaStoyanova = new Student(126, "Yana", "Stoyanova");
            Student VanyaStoyanova = new Student(127, "Vanya", "Stoyanova");

            Teacher AntoanetaPileva = new Teacher("Antoaneta", "Pileva");
            Teacher DimaPileva = new Teacher("Dima", "Pileva");

            ShoolClass A11 = new ShoolClass("11A");
            ShoolClass B11 = new ShoolClass("11B");

            Discipline Biology = new Discipline("Biology", 20, 10);
            Discipline Math = new Discipline("Math", 25, 13);


            A11.AddStudent(GeorgiMollov);

            A11.AddComent("This is First Comment");
                    
            A11.AddStudent(DimoNyagolov);
            A11.AddTeacher(AntoanetaPileva);
            A11.AddDiscipline(Biology);

            Biology.AddComent("This is very hard to learn");
            
            GeorgiMollov.AddComent("very bad student");

            AntoanetaPileva.AddDiscipline(Biology);
            AntoanetaPileva.AddDiscipline(Math);

            B11.AddTeacher(AntoanetaPileva);
            B11.AddTeacher(DimaPileva);
            B11.AddStudent(YanaStoyanova);
            B11.AddDiscipline(Math);
            B11.AddComent("Very good Class of students");

            ICommentable[] coments = {GeorgiMollov, PetyrIvanov, DimoNyagolov, YanaStoyanova, VanyaStoyanova, AntoanetaPileva, DimaPileva
                                         , A11, B11, Biology, Math};

            foreach (var item in coments)
            {
                item.AddComent("Mass Comenting With for each on ICommentable variable");
            }




            
        }

        
    }
}
