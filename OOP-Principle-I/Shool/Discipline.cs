using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Disciplines have name, number of lectures and number of exercises.

namespace Shool
{
    public class Discipline : ICommentable
    {

        private string _disciplineName;
        private int _numberOfLectures;
        private int _numberOfExercises;
        private List<string> _comment = new List<string>();

        public List<string> Comment
        {
            get { return _comment; }
            private set { _comment = value; }
        }

        public string DisciplineName
        {
            get { return _disciplineName; }
            set { _disciplineName = value; }
        }

        public int NumberOfLectures
        {
            get { return _numberOfLectures; }
            set { _numberOfLectures = value; }
        }

        public int NumberOfExercises
        {
            get { return _numberOfExercises; }
            set { _numberOfExercises = value; }
        }

        public Discipline(string dscplName, int nmbOfLctrs, int nmbOfExercis)
        {
            this.DisciplineName = dscplName;
            this.NumberOfLectures = nmbOfLctrs;
            this.NumberOfExercises = nmbOfExercis;
        
        }




        public void AddComent(string comentToAdd)
        {
            this.Comment.Add(comentToAdd);
        }
    }
}
