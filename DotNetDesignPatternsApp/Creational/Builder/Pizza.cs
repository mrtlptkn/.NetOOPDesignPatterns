namespace DotNetDesignPatternsApp.Creational.Builder;

// Pizza nesnesindeki extra alanları set etmek için
// PizzaBuilder nesnesinden yararlanıyoruz.
public class Pizza
{
    // extra peynirli mi ?
    public bool ExtraCheeses { get; private set; }
    public bool ExtraMushrooms { get; private set; }
    public bool ExtraOlives { get; private set; }

    // medium, large, x-large, small
    public string Size { get; }

    public Pizza(string size)
    {
        Size = size;
    }

    public void SetExtraCheese() => ExtraCheeses = true;

    public void SetExtraMushroom() => ExtraMushrooms = true;

    public void SetExtraOlives() => ExtraOlives = true;
}
