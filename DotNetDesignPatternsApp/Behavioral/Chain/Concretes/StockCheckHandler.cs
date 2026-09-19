using DotNetDesignPatternsApp.Behavioral.Chain.Application;
using DotNetDesignPatternsApp.Behavioral.Chain.Contracts;

namespace DotNetDesignPatternsApp.Behavioral.Chain.Concretes;

public class StockCheckHandler : OrderHandler
{
    public override void Handle(OrderRequest orderRequest)
    {
        if (!orderRequest.IsStockAvailable)
        {
            var entity = new Order();
            entity.Status = "REJECTED";
            entity.Reason = "Stokta yeterli ürün bulunmamaktadır!";
            Console.WriteLine("Sipariş reddedildi: Stokta yeterli ürün yok");
        }
        else
        {
            Console.WriteLine("Stok kontrolü başarılı. Sonraki adıma geçiliyor.");
            PassToNext(orderRequest);
        }
    }
}
