using DotNetDesignPatternsApp.Behavioral.Observer.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Observer;

[ApiController]
[Route("api/observer")]
public class ObserverController : ControllerBase
{
    private readonly StockMarketApplication _stockMarketApplication;

    public ObserverController(StockMarketApplication stockMarketApplication)
    {
        _stockMarketApplication = stockMarketApplication;
    }

    [HttpPost("updatePrice")]
    public ActionResult<string> UpdatePrice([FromBody] StockMarketRequest request)
    {
        _stockMarketApplication.Handle(request);
        return Ok("Stock price updated:");
    }
}
