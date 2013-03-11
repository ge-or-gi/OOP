using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Kittent : Cat, ISound
    {

        public Kittent(int age, string name)
            : base(age, name, sex.Female)
        { }



        public override void ProduceSound()
        {
            Console.WriteLine("miauuuu");
        }
    }
}
