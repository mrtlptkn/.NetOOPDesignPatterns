using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;

public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Dark Button rendered with dark theme.");
    }
}
