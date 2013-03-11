using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClassHuman
{
    public abstract class Human
    {
        private string _firstName;
        private string _lastName;

        

        public string LastName
        {
          get { return _lastName; }
          set { _lastName = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
}
