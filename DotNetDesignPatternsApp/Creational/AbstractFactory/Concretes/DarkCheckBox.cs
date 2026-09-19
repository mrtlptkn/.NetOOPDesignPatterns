using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;

public class DarkCheckBox : ICheckBox
{
    public void Render()
    {
        Console.WriteLine("Dark CheckBox boyanıyor.");
    }
}
