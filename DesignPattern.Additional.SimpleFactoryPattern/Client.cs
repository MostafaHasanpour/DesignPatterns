//A cretional design pattern and not a GoF Design Patterns
using System;

namespace DesignPattern.Additional.SimpleFactoryPattern
{
    public static class Client
    {
        public static void UseSimpleFactory()
        {
            Console.WriteLine("*** Simple Factory Pattern Demo***\n");
            IAnimal preferredType = null;

            ISimpleFactory simpleFactory = new SimpleFactory();

            preferredType = simpleFactory.CreateAnimal();

            preferredType.Speak();
            preferredType.Action();

            Console.ReadKey();
        }
    }
}
