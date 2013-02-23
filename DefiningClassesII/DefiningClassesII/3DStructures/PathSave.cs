using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3DStructures
{
    static class PathSave
    {

        static string fileToRead = "../../input.txt";
        static string fileToSave = "../../output.txt";

        static StreamReader input = new StreamReader(fileToRead);
        static StreamWriter output = new StreamWriter(fileToSave);

        public static List<string> fileContent = new List<string>();

        public static void ReadFromFile()
        {

            string line = input.ReadLine();
            string result = "";

            using (input)
            {
                while (line != null)
                {
                    result = line;
                    fileContent.Add(result);

                    line = input.ReadLine();
                    
                }
            }

         }

        public static void SaveToFile(AddPoint ListToSave)
        {
            var lineToSave = ListToSave.PointsList[0];

            using (output)
            {

                for (int i = 0; i < ListToSave.PointsList.Count; i++)
                {
                    lineToSave = ListToSave.PointsList[i];
                    output.WriteLine(lineToSave);
                }


            }


        
        }

    }
}
