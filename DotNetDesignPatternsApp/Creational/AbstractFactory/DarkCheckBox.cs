namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

public class DarkCheckBox : ICheckBox
{
    public void Render()
    {
        Console.WriteLine("Dark CheckBox boyanıyor.");
    }
}
