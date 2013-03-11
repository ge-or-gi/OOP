using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassShape
{
    class AbstractClassShape
    {
        static void Main(string[] args)
        {

            Shape tr = new Triangle(2, 2);
            tr.CalculateSurface();

            Shape rct = new Rectangle(5, 5);
            rct.CalculateSurface();

            Shape crcl = new Circle(3);
            crcl.CalculateSurface();

            Console.WriteLine("---------------------");

            Shape[] arrShapes = new Shape[]
            {
                new Triangle(2,3),
                new Rectangle(5,6),
                new Circle(4),
                new Triangle(5, 6)
            };

            foreach (var item in arrShapes)
            {
                Console.WriteLine("{0} :", item.GetType().Name);
                item.CalculateSurface();
            }

        }
    }
}
