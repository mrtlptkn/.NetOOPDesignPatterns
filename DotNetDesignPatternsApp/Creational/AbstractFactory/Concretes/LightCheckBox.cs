using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;

public class LightCheckBox : ICheckBox
{
    public void Render()
    {
        Console.WriteLine("Light CheckBox oluşturuldu.");
    }
}
