using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classes have unique text identifier
//Each class has a set of teachers.

//additional each class have set of disciplines - not in the homework

namespace Shool
{
    class ShoolClass : ICommentable
    {

        private string _className;
        private List<Teacher> _classTeachers = new List<Teacher>();
        private List<Student> _classStudents = new List<Student>();
        private List<Discipline> _classDisciplines = new List<Discipline>();
        private List<string> _comment = new List<string>();

        public List<string> Comment
        {
            get { return _comment; }
            private set { _comment = value; }
        }
     
        
        public string ClassName
        {
            get { return _className; }
            private set { _className = value; }
        }

        public List<Teacher> ClassTeachers
        {
            get { return _classTeachers; }
            //set { _classTeachers = value; }
        }

        public List<Student> ClassStudents
        {
            get { return _classStudents; }
            //set
            //{
            //}
        }

        public List<Discipline> ClassDisciplines
        {
            get { return _classDisciplines; }
            //set { _classDisciplines = value; }
        }

        public ShoolClass(string clsName)
        {
            this._className = clsName;   
        }

        public void AddTeacher(Teacher teacherToAdd)
        {
            this.ClassTeachers.Add(teacherToAdd);
        }

        public void AddStudent(Student studentToAdd)
        {
            this.ClassStudents.Add(studentToAdd);
        
        }

        public void AddDiscipline(Discipline disciplineToAdd)
        {
            this.ClassDisciplines.Add(disciplineToAdd);
        }



        public void AddComent(string comentToAdd)
        {
            this.Comment.Add(comentToAdd);
        }
    }
}
