using DotNetDesignPatternsApp.Behavioral.TemplateMethod.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.TemplateMethod.Concretes;

// Template Method'daki soyut adýmlarý kahve özelinde dolduran somut sýnýf.
public class Coffee : BeverageTemplate
{
    protected override void BrewMainIngredient()
    {
        Console.WriteLine("Kahve demleniyor...");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Þeker ve süt ekleniyor...");
    }
}
