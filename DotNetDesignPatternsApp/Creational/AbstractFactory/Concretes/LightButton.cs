using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;

public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Light Button render edildi.");
    }
}
