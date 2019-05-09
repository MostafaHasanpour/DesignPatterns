using DesignPattern.Creational.BuilderPattern;
using DesignPattern.Creational.FactoryMethodPattern;
using DesignPattern.Creational.PrototypePattern;
using DesignPattern.Creational.SingletonPattern;
using System;

namespace DesignPatterns.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseSingleton();

            //UsePrototype();

            //UseBuilder();

            UseFactoryMethod();
        }

        private static void UseFactoryMethod()
        {
            Console.WriteLine("***Factory Pattern Demo***\n");

            // Creating a Tiger Factory
            IAnimalFactory tigerFactory = new TigerFactory();

            //Creating a tiger using the Factory Method
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();

            // Creating a Dog Factory
            IAnimalFactory dogFactory = new DogFactory();

            //Creating a tiger using the Factory Method
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();

            Console.ReadLine();
        }

        private static void UseBuilder()
        {
            Console.WriteLine("***Builder Pattern Demo***\n");
            Director director = new Director();

            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new Motorcycle("Honda");

            //Making Car
            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();

            //Making Motorcycle
            director.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();

            Console.ReadLine();
        }

        private static void UsePrototype()
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");
            //Base or Original Copy

            BasicCar nano_base = new Nano("Green Nano") { Price = 100_000 };
            BasicCar ford_base = new Ford("Ford Yellow") { Price = 500_000 };

            BasicCar bc1;
            //Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine($"Car is: {bc1.ModelName}, and it's price is $.  {bc1.Price}");

            //Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine($"Car is: {bc1.ModelName}, and it's price is $.  {bc1.Price}");

            Console.ReadLine();
        }

        private static void UseSingleton()
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");
            //Console.WriteLine(Singleton.MyInt);
            // Private Constructor.So,we cannot use 'new' keyword.
            Console.WriteLine("Trying to create instance s1.");

            Singleton.CreateString("salam");
            Singleton s1 = Singleton.Instance;

            Console.WriteLine("Trying to create instance s2.");

            Singleton.CreateString("khoubi?");
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.Read();
        }
    }
}
