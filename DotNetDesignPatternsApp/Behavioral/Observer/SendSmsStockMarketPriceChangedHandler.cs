namespace DotNetDesignPatternsApp.Behavioral.Observer;

public class SendSmsStockMarketPriceChangedHandler : IStockMarketSubsciber
{
    public void Update(StockMarket stockMarket)
    {
        Console.WriteLine("Stock market price changed. Sending SMS to subscribers: " + stockMarket.Price);
    }
}
