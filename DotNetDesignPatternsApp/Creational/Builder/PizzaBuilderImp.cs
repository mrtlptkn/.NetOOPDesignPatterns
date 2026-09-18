namespace DotNetDesignPatternsApp.Creational.Builder;

// SOLID prensiplerine aykırı bir davranış var
// ama kohezyon açısından bir sorun teşkil etmiyor.
public class PizzaBuilderImp : IPizzaBuilder
{
    private readonly Pizza _pizza;

    public PizzaBuilderImp(string size)
    {
        _pizza = new Pizza(size);
    }

    public IPizzaBuilder WithExtraCheeses()
    {
        _pizza.SetExtraCheese();
        return this;
    }

    public IPizzaBuilder WithExtraMushrooms()
    {
        _pizza.SetExtraMushroom();
        return this;
    }

    public IPizzaBuilder WithExtraOlives()
    {
        _pizza.SetExtraOlives();
        return this;
    }

    public Pizza Build() => _pizza;
}
