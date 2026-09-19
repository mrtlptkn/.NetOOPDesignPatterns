using DotNetDesignPatternsApp.Behavioral.Chain.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Chain;

[ApiController]
[Route("api/chain")]
public class ChainController : ControllerBase
{
    private readonly OrderBestApplicationService _orderApplicationService;

    public ChainController(OrderBestApplicationService orderProcessingService)
    {
        _orderApplicationService = orderProcessingService;
    }

    [HttpPost("test")]
    public ActionResult<string> Test([FromBody] OrderRequest request)
    {
        // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":true,"isStockAvailable":true,"isPaymentVerified":true} -> dolandırıcılık şüphesi var, ilk senaryo
        // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":false,"isStockAvailable":false,"isPaymentVerified":true}
        // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":false,"isStockAvailable":true,"isPaymentVerified":false} test case -> limit yetersiz
        _orderApplicationService.Submit(request);

        return Ok("");
    }
}
