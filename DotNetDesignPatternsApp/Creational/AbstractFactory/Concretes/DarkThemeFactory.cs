using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;

public class DarkThemeFactory : IUIThemeFactory
{
    public IButton CreateButton() => new DarkButton();

    public ITextField CreateTextField() => new DarkTextField();

    public ICheckBox CreateCheckBox() => new DarkCheckBox();
}
