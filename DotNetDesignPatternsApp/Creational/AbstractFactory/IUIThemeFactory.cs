namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

// Abstract Factory
public interface IUIThemeFactory
{
    IButton CreateButton();
    ITextField CreateTextField();
    ICheckBox CreateCheckBox();
}
