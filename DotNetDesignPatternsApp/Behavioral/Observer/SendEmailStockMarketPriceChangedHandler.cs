namespace DotNetDesignPatternsApp.Behavioral.Observer;

public class SendEmailStockMarketPriceChangedHandler : IStockMarketSubsciber
{
    public void Update(StockMarket stockMarket)
    {
        Console.WriteLine("Sending email to subscribers about stock market price change. Current price: " + stockMarket.Price);
    }
}
