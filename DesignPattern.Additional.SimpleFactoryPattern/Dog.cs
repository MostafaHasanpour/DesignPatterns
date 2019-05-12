using System;

//A cretional design pattern and not a GoF Design Patterns
namespace DesignPatterns.Additional.SimpleFactoryPattern
{
    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }

        public void Speak()
        {
            Console.WriteLine("Dogs prefer barking...");
        }
    }
}
