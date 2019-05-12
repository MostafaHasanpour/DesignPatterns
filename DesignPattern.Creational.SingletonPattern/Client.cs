using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.SingletonPattern
{
    public static class Client
    {
        public static void UseSingleton()
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");
            //Console.WriteLine(Singleton.MyInt);
            // Private Constructor.So,we cannot use 'new' keyword.
            Console.WriteLine("Trying to create instance s1.");

            Singleton.CreateString("salam");
            Singleton s1 = Singleton.Instance;

            Console.WriteLine("Trying to create instance s2.");

            Singleton.CreateString("khoubi?");
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.Read();
        }
    }
}
