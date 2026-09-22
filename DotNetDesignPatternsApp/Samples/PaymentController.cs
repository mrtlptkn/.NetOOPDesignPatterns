using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Samples
{
  [Route("api/[controller]")]
  [ApiController]
  public class PaymentController : ControllerBase
  {

    private readonly PaymentApplicationService _paymentApplicationService;

    public PaymentController(PaymentApplicationService paymentApplicationService)
    {
      _paymentApplicationService = paymentApplicationService;
    }


    [HttpPost("pay")]
    public ActionResult<string> ProcessPayment([FromBody] PaymentRequest request)
    {
      // Here you would typically call a service to process the payment
      // For demonstration purposes, we'll just return a success message

      _paymentApplicationService.ProcessPayment(request.paymentMethod);


      return Ok($"Payment processed successfully using {request.paymentMethod}.");

    }
  }
}
