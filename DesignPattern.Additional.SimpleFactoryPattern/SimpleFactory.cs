//A cretional design pattern and not a GoF Design Patterns
using System;

namespace DesignPatterns.Additional.SimpleFactoryPattern
{
    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal CreateAnimal()
        {
            IAnimal intendedAnimal = null;

            Console.WriteLine("Enter your choice:\n0 for Dog\n1 fro Tiger");
            string b1 = Console.ReadLine();
            int input;

            if (int.TryParse(b1, out input))
            {
                Console.WriteLine($"You have entered {input}");
                switch (input)
                {
                    case 0:
                        intendedAnimal = new Dog();
                        break;
                    case 1:
                        intendedAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new ApplicationException("Unknown Animal cannot be instantiated");
                }
            }
            return intendedAnimal;
        }
    }
}
