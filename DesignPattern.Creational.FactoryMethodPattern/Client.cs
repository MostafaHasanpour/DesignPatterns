using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethodPattern
{
    public static class Client
    {
        public static void UseFactoryMethod()
        {
            Console.WriteLine("***Factory Pattern Demo***\n");

            // Creating a Tiger Factory
            IAnimalFactory tigerFactory = new TigerFactory();

            //Creating a tiger using the Factory Method
            //IAnimal aTiger = tigerFactory.CreateAnimal();
            //aTiger.Speak();
            //aTiger.Action();
            IAnimal aTiger = tigerFactory.MakeAnimal();

            // Creating a Dog Factory
            IAnimalFactory dogFactory = new DogFactory();

            //Creating a tiger using the Factory Method
            //IAnimal aDog = dogFactory.CreateAnimal();
            //aDog.Speak();
            //aDog.Action();
            IAnimal aDog = dogFactory.MakeAnimal();

            Console.ReadLine();
        }
    }
}
