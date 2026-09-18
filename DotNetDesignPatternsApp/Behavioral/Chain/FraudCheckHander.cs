namespace DotNetDesignPatternsApp.Behavioral.Chain;

// Her sınıf kendi sorumluluğunu üstlendiği için single responsibility prensibine uygun bir yapı ortaya çıkıyor.
// Her handler, sadece kendi kontrolünü yapar ve eğer kontrol başarılı ise sıradaki handler'a geçer.
// Bu sayede kod daha modüler, okunabilir ve bakımı kolay hale gelir.
// Tip: Behavioral design pattern'lerin hepsi single responsibility'ye uygundur. Çünkü sorumluluğu
// farklı farklı sınıflara devretmek için yapılır.

// Concrete Handler
public class FraudCheckHander : OrderHandler
{
    // Burada bir sahtecilik kontrolü yapılmalı
    // FraudCheckHander'da ne yapacağız kısmı ile Handle methodu ilgileniyor.
    public override void Handle(OrderRequest orderReq)
    {
        if (orderReq.IsFraud)
        {
            var entity = new Order();
            entity.Status = "REJECTED";
            entity.Reason = "Sahtecilik şüphesi tespit edildi!";
            Console.WriteLine("Sipariş reddedildi: Sahtecilik şüphesi");
        }
        else
        {
            Console.WriteLine("Sahtecilik kontrolü başarılı. Sonraki adıma geçiliyor.");
            PassToNext(orderReq);
        }
    }
}
