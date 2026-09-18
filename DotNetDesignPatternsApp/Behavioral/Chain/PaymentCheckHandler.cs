namespace DotNetDesignPatternsApp.Behavioral.Chain;

public class PaymentCheckHandler : OrderHandler
{
    public override void Handle(OrderRequest orderRequest)
    {
        if (orderRequest.IsPaymentVerified)
        {
            var entity = new Order();
            entity.Status = "Approved";
            entity.Reason = "Ödeme doğrulandı, sipariş onaylandı!";
            Console.WriteLine("Sipariş onaylandı: Ödeme doğrulandı");

            // yeni bir işlem eklenirse zincire eklenebilir, bu yüzden PassToNext çağırıyoruz.
            PassToNext(orderRequest); // finalize state
        }
        else
        {
            var entity = new Order();
            entity.Status = "REJECTED";
            entity.Reason = "Ödeme doğrulanamadı!";
            Console.WriteLine("Sipariş reddedildi: Ödeme doğrulanamadı");
            PassToNext(orderRequest);
        }
    }
}
