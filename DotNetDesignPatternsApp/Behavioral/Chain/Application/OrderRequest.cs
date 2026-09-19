namespace DotNetDesignPatternsApp.Behavioral.Chain.Application;

// Sepetteki ürünleri girip siparişe çevirecek. Bu sebeple müşteri No ve Sepet Code yeterlidir.
// IsFraud, IsStockAvailable, IsPaymentVerified aslında basketCode'a göre sepetteki ürünlere ve müşteri numarasına göre
// servisten bulunacak şeyler ama uğraşmamak için buraya dinamik olarak değer gönderdik.
public record OrderRequest(
    string BasketCode,
    string CustomerNumber,
    bool IsFraud,
    bool IsStockAvailable,
    bool IsPaymentVerified);
