using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Karayoluyla teslimat gerçekleştirildi (Truck)");
    }
}
