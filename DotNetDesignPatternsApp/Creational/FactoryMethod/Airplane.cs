namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

public class Airplane : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Havayoluyla teslimat gerçekleştirildi (Airplane)");
    }
}
