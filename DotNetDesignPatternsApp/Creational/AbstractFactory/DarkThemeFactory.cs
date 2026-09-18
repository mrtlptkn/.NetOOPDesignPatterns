namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

public class DarkThemeFactory : IUIThemeFactory
{
    public IButton CreateButton() => new DarkButton();

    public ITextField CreateTextField() => new DarkTextField();

    public ICheckBox CreateCheckBox() => new DarkCheckBox();
}
