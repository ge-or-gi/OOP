using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClassHuman
{
    public class Student : Human
    {
        public int Grade { get; set; }

        public Student(int grade, string fName, string lName)
            : base(fName, lName)
        {
            this.Grade = grade;
        }
    }
}
