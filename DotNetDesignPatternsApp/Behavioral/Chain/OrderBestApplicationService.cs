namespace DotNetDesignPatternsApp.Behavioral.Chain;

// OrderProcessing Service; FraudCheckHander, StockCheckHandler ve PaymentCheckHandler'ı birbirine bağlar ve
// sipariş işleme sürecini başlatır. Bu servisin ana görevi alt sınıfların birbirleri ile koordineli çalışmalarını sağlamaktır.
public class OrderBestApplicationService
{
    private readonly FraudCheckHander _fraudCheckHander;

    public OrderBestApplicationService(
        FraudCheckHander fraudCheckHander,
        StockCheckHandler stockCheckHandler,
        PaymentCheckHandler paymentCheckHandler)
    {
        _fraudCheckHander = fraudCheckHander;
        fraudCheckHander.SetNext(stockCheckHandler).SetNext(paymentCheckHandler);
    }

    public void Submit(OrderRequest orderRequest)
    {
        // Sipariş işleme süreci başlatılır
        // Burada ise akış kontrollerini başlatıyoruz
        _fraudCheckHander.Handle(orderRequest);
    }
}
