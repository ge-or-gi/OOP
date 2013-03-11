using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassShape
{
    class Rectangle : Shape
    {
        public Rectangle(int heigh, int weight) : base(heigh, weight) { }

        public override void CalculateSurface()
        {
            Console.WriteLine(Heigh * Weight);
        }
    }
}
