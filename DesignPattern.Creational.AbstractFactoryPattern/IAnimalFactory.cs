namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
