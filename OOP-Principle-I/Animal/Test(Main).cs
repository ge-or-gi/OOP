using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
// Dogs, frogs and cats are Animals. 
// All animals can produce sound (specified by the ISound interface). 
// Kittens and tomcats are cats.
// All animals are described by age, name and sex. 
// Kittens can be only female and tomcats can be only male. 
// Each animal produces a specific sound. 
// Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {


            Animal[] arrOfAnimals = new Animal[] 
            {
                new Dog ("Sharo", 12, Animal.sex.Male),
                new Frog (10, "Princ", Animal.sex.Male),
                new Frog (12, "Princes", Animal.sex.Female),
                new Frog (9, "Kermit", Animal.sex.Male),
                new Kittent (10, "Macka"),
                new Kittent (9,"Pisana"),
                new Kittent (5,"Sladurana"),
                new Tomcat (15,"kotarak1"),
                new Tomcat (12,"kotoarak2"),
                new Dog ("BauBau", 13, Animal.sex.Male)
            };

            

            foreach (var item in arrOfAnimals) //.OrderBy(x => x.GetType()))
            {
                Console.Write("{0} {1} : {2} {3} : ", item.Age, item.Name, item.Sex, item.GetType().Name);
                item.ProduceSound();
            }

            Console.WriteLine();
            Console.WriteLine();

            GetAverageAgeOfAll(arrOfAnimals);


        }

        private static void GetAverageAgeOfAll(Animal[] arrOfAnimals)
        {

            var GroupAnimalsByTypes = arrOfAnimals.GroupBy(x => x.GetType());

            foreach (var animalGroup in GroupAnimalsByTypes)
            {
                Console.Write("{0} : ", animalGroup.Key);

                var averageAge = animalGroup.Average(x => x.Age);
                Console.WriteLine("Average Age : {0}", averageAge);

            }
        }
    }
}
