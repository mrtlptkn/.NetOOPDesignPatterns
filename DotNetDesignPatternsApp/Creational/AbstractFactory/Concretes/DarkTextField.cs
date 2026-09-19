using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;

public class DarkTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("Koyu temalı bir metin kutusu oluşturuldu.");
    }
}
