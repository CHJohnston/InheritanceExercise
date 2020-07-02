using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class


            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird bird1 = new Bird()
            {
                AnimalType = "Parrot",
                Age = 2,
                Sex = "F",
                SkinCovering = "Feathers",
                BeakType = "HookBill",
                MakeGoodPet = true,
                NestType = "Nest Box",
                CanFly = true,
            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile1 = new Reptile()
            {
                AnimalType = "Land Tortoise",
                Age = 4,
                Sex = "M",
                CanFly = false,
                SkinCovering = "a Shell",
                LiveBirth = false,
                DoesSwim = false,
                UseLegs = true,
                EatLiveFood = false                
             };

            //This creates a LIST of Animal 
            List<Animal> animals = new List<Animal>();
            animals.Add(bird1);
            animals.Add(reptile1);

            //This prints all the items in the animials List
            foreach (Animal myAnimal in animals) 
            {
                Console.WriteLine($"This {myAnimal.AnimalType} is a {myAnimal.GetType().Name} and is {myAnimal.Age } years old");
                Console.Write($"It has {myAnimal.SkinCovering} for a skin covering. ");
                if (myAnimal.Sex == "M")
                    Console.WriteLine($"It is a Male.");
                if (myAnimal.Sex == "F")
                    Console.WriteLine($"It is a Female.");
                myAnimal.Fly(myAnimal.CanFly);
                Console.WriteLine();
            }
        }
    }
}
