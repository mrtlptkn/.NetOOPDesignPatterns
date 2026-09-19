namespace DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;

// Abstract Factory
public interface IUIThemeFactory
{
    IButton CreateButton();
    ITextField CreateTextField();
    ICheckBox CreateCheckBox();
}
