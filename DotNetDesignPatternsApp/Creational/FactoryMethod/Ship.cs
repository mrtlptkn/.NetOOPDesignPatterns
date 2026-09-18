namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Denizyoluyla teslimat gerçekleştirildi (Ship)");
    }
}
