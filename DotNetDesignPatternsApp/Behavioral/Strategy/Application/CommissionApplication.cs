using DotNetDesignPatternsApp.Behavioral.Strategy.Concretes;
using DotNetDesignPatternsApp.Behavioral.Strategy.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Strategy.Application;

// Strategy tasarım deseni ile bir alakası yok, sadece gelen parametreye göre doğru strategy'yi buldurmamız gerekiyor.
// O yüzden bu class'ı service yaparak gelen parametreye göre strategy buldurmuş oluyoruz.
// Hangi tipte bir şirketle hangi tipte bir komisyon hesabı var bunu yönlendirmek (Router görevi görmek)
public class CommissionApplication
{
    private readonly Dictionary<string, ICommissionStrategy> _strategyMap = new();

    public CommissionApplication()
    {
        _strategyMap[EnterprisesConsts.LargeEnterprise] = new LargeEnterprises();
        _strategyMap[EnterprisesConsts.MediumEnterprise] = new MediumEnterprises();
        _strategyMap[EnterprisesConsts.SmallEnterprise] = new SmallEnterprises();
    }

    public ICommissionStrategy GetStrategy(string enterpriseType)
    {
        if (_strategyMap.TryGetValue(enterpriseType, out var strategy))
        {
            return strategy;
        }

        throw new InvalidOperationException("Invalid enterprise type: " + enterpriseType);
    }

    public void Handle(CommissionRequest request)
    {
        // strateji var mı ?
        ICommissionStrategy strategy = GetStrategy(request.Enterprise);
        // varsa strategy uygular.
        decimal value = strategy.Apply(request.Amount, request.Currency);
        Console.WriteLine("Final amount after commission: " + value + " " + request.Currency);
    }
}
