using System;

namespace DesignPatterns.Structural.ProxyPattern
{
    public class ConcreteSubject2 : Subject
    {
        public override void DoSomework()
        {
            Console.WriteLine("Not Allow ConcreteSubject2.DoSomework()");
        }
    }
}
