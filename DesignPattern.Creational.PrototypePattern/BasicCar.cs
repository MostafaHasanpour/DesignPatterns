using System;

namespace DesignPatterns.Creational.PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName { get; set; }
        public int Price { get; set; }

        public static int SetPrice()
        {
            int price = 0;
            Random r = new Random();
            price = r.Next(20000,100000);
            return price;
        }
        public abstract BasicCar Clone();
    }
}
