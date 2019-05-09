using DesignPattern.Creational.BuilderPattern;
using DesignPattern.Creational.FactoryMethodPattern;
using DesignPattern.Creational.PrototypePattern;
using DesignPattern.Creational.SingletonPattern;
using System;

namespace DesignPatterns.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //DesignPattern.Creational.SingletonPattern.Client.UseSingleton();

            //DesignPattern.Creational.PrototypePattern.Client.UsePrototype();

            //DesignPattern.Creational.BuilderPattern.Client.UseBuilder();

            //DesignPattern.Creational.FactoryMethodPattern.Client.UseFactoryMethod();

            DesignPattern.Additional.SimpleFactoryPattern.Client.UseSimpleFactory();
        }



    }
}
