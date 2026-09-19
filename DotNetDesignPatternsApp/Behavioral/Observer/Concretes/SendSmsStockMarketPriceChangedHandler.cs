using DotNetDesignPatternsApp.Behavioral.Observer.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Observer.Concretes;

public class SendSmsStockMarketPriceChangedHandler : IStockMarketSubsciber
{
    public void Update(StockMarket stockMarket)
    {
        Console.WriteLine("Stock market price changed. Sending SMS to subscribers: " + stockMarket.Price);
    }
}
