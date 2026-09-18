namespace DotNetDesignPatternsApp.Behavioral.Observer;

public class StockMarket
{
    public decimal Price { get; private set; } = 0m; // fiyat

    public string? Name { get; set; } // isim

    private readonly List<IStockMarketSubsciber> _subscibers = new();

    public void ChangePrice(decimal newPrice)
    {
        Price = newPrice;
        // event ise fiyatın güncellenmesi
        NotifySubscibers();
    }

    // fiyat değişiminde tüm subscriber'ları tetikleyen method.
    public void NotifySubscibers()
    {
        foreach (IStockMarketSubsciber subsciber in _subscibers)
        {
            subsciber.Update(this);
        }
    }

    // yeni bir gözlemci ekliyoruz.
    public void AddSubsciber(IStockMarketSubsciber subsciber)
    {
        _subscibers.Add(subsciber);
    }

    // işimiz bitince gözlemleyicileri ortadan kaldırıyoruz.
    public void RemoveSubsciber(IStockMarketSubsciber subsciber)
    {
        _subscibers.Remove(subsciber);
    }
}
