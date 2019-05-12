using System;

namespace DesignPatterns.Structural.ProxyPattern
{
    public class ConcreteSubject1 : Subject
    {
        public override void DoSomework()
        {
            Console.WriteLine("Allow ConcreteSubject1.DoSomework()");
        }
    }
}
