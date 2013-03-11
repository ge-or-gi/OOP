using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Students have name and unique class number.

namespace Shool
{
    public class Student : Person, ICommentable
    {
        private int _classNumber;
        private List<string> _comment = new List<string>();

        public List<string> Comment
        {
            get { return _comment; }
            private set { _comment = value; }
        }

        

        public int ClassNumber
        {
            get { return _classNumber; }
            private set { _classNumber = value; }
        }

        public Student(int clsNumber, string fName, string lName)
            : base(fName, lName)
        {
            this._classNumber = clsNumber;
        }


        public void AddComent(string comenttoAdd)
        {
            this.Comment.Add(comenttoAdd);
        }
    }
}
