using System;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using a decorator***");
            //Decorating now

            AddFloor();
            //You can put additional stuff as per your needs.
        }

        private void AddFloor()
        {
            Console.WriteLine("I am making an additional floor on top of it.");
        }
    }
}
