using DotNetDesignPatternsApp.Behavioral.Observer.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Observer.Application;

// Application katmanı controller'a gelen isteğe göre arka plandaki sınıflara ait hazırlıkları yapar.
// Application class ismi vermemizin sebebi bu.
public class StockMarketApplication
{
    private readonly SendEmailStockMarketPriceChangedHandler _sendEmailStockMarketPriceChangedHandler;
    private readonly SendSmsStockMarketPriceChangedHandler _sendSmsStockMarketPriceChangedHandler;

    private readonly StockMarket _stockMarket;

    public StockMarketApplication(
        SendEmailStockMarketPriceChangedHandler sendEmailStockMarketPriceChangedHandler,
        SendSmsStockMarketPriceChangedHandler sendSmsStockMarketPriceChangedHandler,
        StockMarket stockMarket)
    {
        _sendEmailStockMarketPriceChangedHandler = sendEmailStockMarketPriceChangedHandler;
        _sendSmsStockMarketPriceChangedHandler = sendSmsStockMarketPriceChangedHandler;
        _stockMarket = stockMarket; // Stock Market singleton instance
        // subscriber'ları ayağa kaldırdık
    }

    public void Handle(StockMarketRequest request)
    {
        Console.WriteLine("Updating stock price to: " + request.NewPrice);
        // talep öncesi ekle
        _stockMarket.AddSubsciber(_sendEmailStockMarketPriceChangedHandler);
        _stockMarket.AddSubsciber(_sendSmsStockMarketPriceChangedHandler);

        _stockMarket.ChangePrice(request.NewPrice);

        // Singleton instance aldığımız için bunu yapmazsak 2. gönderimde subscriber'lar iki kez eklenir ve eventler mükerrer tetiklenir.
        // talep sonrası kaldır.
        _stockMarket.RemoveSubsciber(_sendEmailStockMarketPriceChangedHandler);
        _stockMarket.RemoveSubsciber(_sendSmsStockMarketPriceChangedHandler);
    }
}
