namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

public class LightCheckBox : ICheckBox
{
    public void Render()
    {
        Console.WriteLine("Light CheckBox oluşturuldu.");
    }
}
