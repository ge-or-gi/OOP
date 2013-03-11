using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Tomcat: Cat, ISound
    {

        public Tomcat(int age, string name) : base(age, name, sex.Male) { }



        public override void ProduceSound()
        {
            Console.WriteLine("RRRRRRRR");
        }
    }
}
