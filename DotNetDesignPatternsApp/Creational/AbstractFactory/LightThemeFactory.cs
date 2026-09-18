namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

// Bu sınıfın amacı gerçekten bize light concrete product üretmek.
public class LightThemeFactory : IUIThemeFactory
{
    public IButton CreateButton() => new LightButton();

    public ITextField CreateTextField() => new LightTextField();

    public ICheckBox CreateCheckBox() => new LightCheckBox();
}
