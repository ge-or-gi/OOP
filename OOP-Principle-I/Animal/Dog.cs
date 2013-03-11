using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Animal, ISound
    {

        public Dog(string name, int age, sex sex)
            : base(age, name, sex)
        { }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
