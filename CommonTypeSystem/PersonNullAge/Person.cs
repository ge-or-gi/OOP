using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNullAge
{
    class Person
    {

        private int? _age;

        public int? Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string fName, int? age = null)
        {
            this.Age = age;
            this.Name = fName;
        }

        public override string ToString()
        {
            return string.Format("Name : {0} - Age : {1}", this.Name,
                this.Age == null  ? "Age not Specified" : this.Age.ToString());
        }
        


    }
}
