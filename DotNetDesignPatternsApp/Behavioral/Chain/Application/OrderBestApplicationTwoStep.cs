using DotNetDesignPatternsApp.Behavioral.Chain.Concretes;

namespace DotNetDesignPatternsApp.Behavioral.Chain.Application
{
  public class OrderBestApplicationTwoStep
  {


    private readonly FraudCheckHander _fraudCheckHander;

    public OrderBestApplicationTwoStep(
        FraudCheckHander fraudCheckHander,
        PaymentCheckHandler paymentCheckHandler)
    {
      _fraudCheckHander = fraudCheckHander;
      _fraudCheckHander.SetNext(paymentCheckHandler);
    }

    public void Submit(OrderRequest orderRequest)
    {
      // Sipariş işleme süreci başlatılır
      // Burada ise akış kontrollerini başlatıyoruz
      _fraudCheckHander.Handle(orderRequest);
    }

  }
}
