using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            Point myFirstPoint = new Point();  // кординати на първата точка
            myFirstPoint.PointX = 3;            // зададени по стандартен начин
            myFirstPoint.PointY = 4;
            myFirstPoint.PointZ = 5;

            Console.WriteLine(myFirstPoint.ToString());         // първа точка на конзолата


            Point mySecondPoint = new Point() { PointX = 6, PointY = 7, PointZ = 8 };       //координати втора точка - нов синтаксис
            Console.WriteLine(mySecondPoint.ToString());                                     // втора точка на конзолата

            double distance = DistanceBtwPoints.Distance(myFirstPoint, mySecondPoint);      // извикава метод който изчислява разстоянието
            Console.WriteLine(distance);                                                    // разстояние на конзолата

            AddPoint myPath = new AddPoint();           //класа има ЛИСТ който събира елементи от тип ПОИНТ 

            myPath.PointsList.Add(myFirstPoint);
            myPath.PointsList.Add(mySecondPoint);

            myPath.PointsList.Add(new Point(7, 8, 9));
            myPath.PointsList.Add(new Point(7, 8, 9));
            myPath.PointsList.Add(new Point(7, 8, 9));
            myPath.PointsList.Add(new Point(7, 8, 9));

            PathSave.ReadFromFile();                 //прочита съдържанието на файл и запазва неговото съдържание в ЛИСТ от стрингове

            for (int i = 0; i < PathSave.fileContent.Count; i++)
            {
              myPath.PointsList.Add(new Point(PathSave.fileContent[i]));            //извиква конструктор за ПОИНТ който приема СТРИНГ
            }


            distance = DistanceBtwPoints.Distance(myPath.PointsList[4], myPath.PointsList[5]);      //изчисляване на разстояние от точка до точка - добавени в ЛИСТ, по индекс в ЛИСТА
            Console.WriteLine(distance);
            


            PathSave.SaveToFile(myPath);
            

        }
    }
}
