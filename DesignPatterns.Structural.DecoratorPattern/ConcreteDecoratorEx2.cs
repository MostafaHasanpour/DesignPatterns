using System;

namespace DesignPatterns.Structural.DecoratorPattern
{
    public class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            Console.WriteLine("");
            base.MakeHouse();
            Console.WriteLine("***Using another decorator***");
            //Decorating now
            PaintTheHouse();
            //You can put additional stuff as per your needs.
        }

        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }
}
