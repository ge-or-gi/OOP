using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shool
{
    public abstract class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        
        }

        
    }
}
