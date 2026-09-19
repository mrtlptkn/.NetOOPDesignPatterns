using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;

public class LightTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("Light temalı TextField oluşturuldu.");
    }
}
