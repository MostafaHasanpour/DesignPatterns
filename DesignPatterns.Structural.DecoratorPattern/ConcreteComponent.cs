using System;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("Original House is complete. It is closed for modification.");
        }
    }
}
