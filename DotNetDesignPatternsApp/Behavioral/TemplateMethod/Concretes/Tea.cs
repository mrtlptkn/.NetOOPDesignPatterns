using DotNetDesignPatternsApp.Behavioral.TemplateMethod.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.TemplateMethod.Concretes;

// Template Method'daki soyut adımları çay özelinde dolduran somut sınıf.
// Bu örnekte hook metodu override edilerek koşul eklentisi (limon) istenmediği belirtilir.
public class Tea : BeverageTemplate
{
    protected override void BrewMainIngredient()
    {
        Console.WriteLine("Çay demleniyor...");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Limon ekleniyor...");
    }

    protected override bool WantsCondiments() => false;
}
