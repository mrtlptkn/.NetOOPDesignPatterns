using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;

public class Airplane : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Havayoluyla teslimat gerçekleştirildi (Airplane)");
    }
}
