using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.PrototypePattern
{
    public static class Client
    {

        public static void UsePrototype()
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
    }
}
