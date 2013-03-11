using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, sex sex)
            : base(age, name, sex)
        { }



        public override void ProduceSound()
        {
            Console.WriteLine("Frog Frog Frog");
        }
    }
}
