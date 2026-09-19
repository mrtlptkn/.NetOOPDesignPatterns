using DotNetDesignPatternsApp.Creational.Builder.Concretes;

namespace DotNetDesignPatternsApp.Creational.Builder.Contracts;

// aşağıdaki ekstra özelliklerde bir pizza oluşturmak istiyoruz.
public interface IPizzaBuilder
{
    IPizzaBuilder WithExtraCheeses();
    IPizzaBuilder WithExtraMushrooms();
    IPizzaBuilder WithExtraOlives();

    Pizza Build();
}
