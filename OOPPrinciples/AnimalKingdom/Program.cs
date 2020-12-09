using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat(5, "Puflek");
            Cat cat = new Cat(7, "Fastu4ko");
            Dog dog = new Dog(4, "6aro");

            Console.WriteLine(animal.MakeNoise());
            Console.WriteLine(animal.MakeTrick());

            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(cat.MakeTrick());

            Console.WriteLine(dog.MakeNoise());
            Console.WriteLine(dog.MakeTrick());
        }


    }
}
