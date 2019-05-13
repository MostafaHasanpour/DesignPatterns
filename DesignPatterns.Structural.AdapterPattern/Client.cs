using System;

namespace DesignPatterns.Structural.AdapterPattern
{
    public static class Client
    {
        public static void UseAdapter()
        {
            Console.WriteLine("***Adapterr Pattern Demo***\n");

            CalculatorAdapter cal = new CalculatorAdapter();
            Triangle t = new Triangle(20, 10);
            Console.WriteLine($"Area of triangle is {cal.GetArea(t)} Square unit");

            Console.ReadLine();
        }
    }
}
