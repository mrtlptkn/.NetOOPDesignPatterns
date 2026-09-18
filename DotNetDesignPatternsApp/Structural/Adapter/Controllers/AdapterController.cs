using DotNetDesignPatternsApp.Structural.Adapter.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Structural.Adapter.Controllers;

[ApiController]
[Route("api/adapter")]
public class AdapterController : ControllerBase
{
    private readonly BankPaymentApplication _bankPaymentApplication;

    public AdapterController(BankPaymentApplication bankPaymentApplication)
    {
        _bankPaymentApplication = bankPaymentApplication;
    }

    [HttpPost("pay")]
    public ActionResult<string> MakePay([FromBody] PaymentRequest request)
    {
        _bankPaymentApplication.Handle(request);
        return Ok("Adapter ile odeme yapildi: ");
    }
}
