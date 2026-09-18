namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Light Button render edildi.");
    }
}
