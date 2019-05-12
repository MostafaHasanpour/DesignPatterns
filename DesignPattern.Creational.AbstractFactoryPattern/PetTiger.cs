using System;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public class PetTiger : ITiger
    {
        public void Action()
        {
            Console.WriteLine("Pet Tigers play in an animal circus.\n.");
        }

        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.");
        }
    }
}
