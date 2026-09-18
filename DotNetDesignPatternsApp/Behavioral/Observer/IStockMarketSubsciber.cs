namespace DotNetDesignPatternsApp.Behavioral.Observer;

public interface IStockMarketSubsciber
{
    void Update(StockMarket stockMarket);
}
