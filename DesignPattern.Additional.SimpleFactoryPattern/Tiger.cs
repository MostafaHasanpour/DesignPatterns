using System;

//A cretional design pattern and not a GoF Design Patterns
namespace DesignPattern.Additional.SimpleFactoryPattern
{
    public class Tiger : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tiger says: Halum.");
        }

        public void Speak()
        {
            Console.WriteLine("Tigers prefer hunting...");
        }
    }
}
