namespace DotNetDesignPatternsApp.Creational.Builder;

// Builder tasarım deseni ile hiçbir alakası yok.
// Burada requestten gelen talebe göre doğru nesneyi oluşturmayı yönetiyoruz.
// Genelde bu tarz sınıflar için ya Manager suffix ya da Application, Client suffix kullanırız.
// Controller'dan çağırılacak olan Manager Service, Application Service bu.
//
// Spring'deki @Scope("prototype") karşılığı: DI kaydı AddTransient
// (her çağrıldığında yeni bir instance oluşturulur, isteğe özel nesne yönetimi için).
public class PizzaApplication
{
    internal Pizza Create(PizzaRequest request)
    {
        IPizzaBuilder builder = new PizzaBuilderImp(request.Size);

        if (request.ExtraCheeses)
            builder.WithExtraCheeses();

        if (request.ExtraMushrooms)
            builder.WithExtraMushrooms();

        if (request.ExtraOlives)
            builder.WithExtraOlives();

        return builder.Build();
    }
}
