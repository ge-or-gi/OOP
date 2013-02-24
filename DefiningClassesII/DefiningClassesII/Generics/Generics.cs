using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    class Generics
    {
        static void Main(string[] args)
        {


            ItemList<string> myStrigs = new ItemList<string>(3);

            ItemList<int> myInts = new ItemList<int>(3);

            myInts.Add(5);
            myStrigs.Add("pet");

            myInts.Add(7);
            myInts.Add(8);
            myInts.Add(9);
            myInts.Add(10);
            myInts.Add(11);
            myInts.Add(12);

            Console.WriteLine(myInts[1]);

            myInts[3] = 55;

            myInts.InsertElement(2, 55);

            myInts.RemoveElement(2);

            myStrigs.InsertElement(2, "Petko");

            myStrigs.RemoveElement(2);

            int result = ItemList<int>.Max(myInts[3], myInts[2]);

            string result2 = ItemList<string>.Max(myStrigs[1], myStrigs[3]);
            

            
        }
    }
}
