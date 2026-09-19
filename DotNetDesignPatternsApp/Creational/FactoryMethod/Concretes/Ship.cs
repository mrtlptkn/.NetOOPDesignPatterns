using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Denizyoluyla teslimat gerçekleştirildi (Ship)");
    }
}
