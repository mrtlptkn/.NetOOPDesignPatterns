using DotNetDesignPatternsApp.Behavioral.Observer.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Observer.Contracts;

public interface IStockMarketSubsciber
{
    void Update(StockMarket stockMarket);
}
