﻿using System;
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
    abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public enum sex {Male, Female};
        public sex Sex { get; set; }

        public Animal(int age, string name, sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public abstract void ProduceSound();
    }
}
