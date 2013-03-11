using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Teachers have name.
//Each teacher teaches a set of disciplines

namespace Shool
{
    public class Teacher : Person, ICommentable
    {
        private List<string> _comment = new List<string>();

        public List<string> Comment
        {
            get { return _comment; }
            private set { _comment = value; }
        }

        public Teacher(string fName, string lName)
            : base(fName, lName)  { }

        private List<Discipline> _discipline = new List<Discipline>();

        public List<Discipline> Discipline
        {
            get { return _discipline; }
            //set { _discipline = value; }
        }

        public void AddDiscipline(Discipline disciplineToAdd)
        {
            this.Discipline.Add(disciplineToAdd);
        }



        public void AddComent(string comentToAdd)
        {
            this.Comment.Add(comentToAdd);
        }
    }
}
