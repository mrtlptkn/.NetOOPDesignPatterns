namespace DotNetDesignPatternsApp.Behavioral.Strategy.Contracts;

// Strategy bazlı kullanılan sınıfı runtime'da belirleyen bir yöntem
// SRP'ye de DIP'e de uygundur.
public interface ICommissionStrategy
{
    decimal Apply(decimal amount, string currency);
}
