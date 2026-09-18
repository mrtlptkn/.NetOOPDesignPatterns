namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Dark Button rendered with dark theme.");
    }
}
