namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

public class DarkTextField : ITextField
{
    public void Render()
    {
        Console.WriteLine("Koyu temalı bir metin kutusu oluşturuldu.");
    }
}
