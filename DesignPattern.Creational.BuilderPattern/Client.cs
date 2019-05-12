using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.BuilderPattern
{
    public static class Client
    {
        public static void UseBuilder()
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
    }
}
