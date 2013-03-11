using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Cat : Animal
    {
        public Cat(int age, string name, sex sex) : base(age, name, sex) { }
    }
}
