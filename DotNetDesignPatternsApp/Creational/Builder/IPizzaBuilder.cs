namespace DotNetDesignPatternsApp.Creational.Builder;

// aşağıdaki ekstra özelliklerde bir pizza oluşturmak istiyoruz.
public interface IPizzaBuilder
{
    IPizzaBuilder WithExtraCheeses();
    IPizzaBuilder WithExtraMushrooms();
    IPizzaBuilder WithExtraOlives();

    Pizza Build();
}
