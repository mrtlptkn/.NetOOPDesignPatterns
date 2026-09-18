namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

public class LightTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("Light temalı TextField oluşturuldu.");
    }
}
