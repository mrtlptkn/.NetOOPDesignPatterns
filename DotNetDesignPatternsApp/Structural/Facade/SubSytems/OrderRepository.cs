using DotNetDesignPatternsApp.Structural.Facade.Domain;

namespace DotNetDesignPatternsApp.Structural.Facade.SubSytems;

public class OrderRepository
{
    public void Save()
    {
        var order = new Order();
        order.OrderedAt = DateOnly.FromDateTime(DateTime.Now);
        order.ShippedAt = DateOnly.FromDateTime(DateTime.Now).AddDays(2);
        order.Code = "ORD123456";

        var orderLine = new OrderLine();
        orderLine.LineTotal = 100.0m;
        orderLine.OrderId = order.Id;
        orderLine.ProductId = 1L;

        // Spring Data JPA Repository save yerine: EF Core -> dbContext.Orders.Add(order); dbContext.SaveChanges();

        Console.WriteLine("Siparis veritabanina kaydedildi.");
    }
}
