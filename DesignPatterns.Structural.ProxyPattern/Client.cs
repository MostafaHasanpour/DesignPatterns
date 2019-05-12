using System;

namespace DesignPatterns.Structural.ProxyPattern
{
    public static class Client
    {
        public static void UseProxy()
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");

            Proxy px1 = new Proxy("Admin");
            px1.DoSomework();

            Console.WriteLine("\n\n");

            Proxy px2 = new Proxy("Mostafa");
            px2.DoSomework();

            Console.ReadLine();
        }
    }
}
