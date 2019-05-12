using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public static class Client
    {

        public static void UseAbstractFactory()
        {
            Console.WriteLine("***Abstract Factory Pattern Demo***\n");

            Console.WriteLine("***********Wild Animals************");

            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();

            //Making a wild dog through WildAnimalFactory
            IDog wildDog = wildAnimalFactory.GetDog();
            wildDog.Speak();
            wildDog.Action();

            //Making a wild tiger through WildAnimalFactory
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();

            Console.WriteLine("***********Pet Animals************");

            IAnimalFactory petAnimalFactory = new PetAnimalFactory();

            //Making a pet dog through WildAnimalFactory
            IDog petDog = petAnimalFactory.GetDog();
            petDog.Speak();
            petDog.Action();

            //Making a pet tiger through WildAnimalFactory
            ITiger petTiger = petAnimalFactory.GetTiger();
            petTiger.Speak();
            petTiger.Action();

            Console.ReadLine();
        }
    }
}
