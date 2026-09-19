namespace DotNetDesignPatternsApp.Behavioral.TemplateMethod.Contracts;

// Template Method: bir algoritmanın iskeletini (adımların sırasını) tanımlayan soyut sınıf.
// Algoritmanın genel akışı (MakeBeverage) burada sabitlenir; alt sınıflar sadece kendine özgü
// adımları (BrewMainIngredient, AddCondiments) override ederek özelleştirir.
public abstract class BeverageTemplate
{
    // Template Method: alt sınıflarda değiştirilemesin diye 'sealed' benzeri davranış için non-virtual bırakıldı.
    public void MakeBeverage()
    {
        BoilWater();
        BrewMainIngredient();
        PourInCup();

        if (WantsCondiments())
        {
            AddCondiments();
        }
    }

    private void BoilWater()
    {
        Console.WriteLine("Su kaynatılıyor...");
    }

    private void PourInCup()
    {
        Console.WriteLine("Bardağa dökülüyor...");
    }

    protected abstract void BrewMainIngredient();

    protected abstract void AddCondiments();

    // Hook: alt sınıflar isterse override edip davranışı değiştirebilir, zorunlu değildir.
    protected virtual bool WantsCondiments() => true;
}
