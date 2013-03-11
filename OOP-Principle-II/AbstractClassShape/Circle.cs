using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassShape
{
    class Circle:Shape
    {
        public Circle(int radius) : base(radius, radius) { }

        public override void CalculateSurface()
        {
            Console.WriteLine((Heigh * Heigh) * 3.14);
        }
    }
}
