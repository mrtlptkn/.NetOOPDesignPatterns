using DotNetDesignPatternsApp.Behavioral.Chain.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Chain;

[ApiController]
[Route("api/chain")]
public class ChainController : ControllerBase
{
    private readonly OrderBestApplicationService _orderApplicationService;
  private readonly OrderBestApplicationTwoStep _orderApplicationTwoStepService;

  public ChainController(OrderBestApplicationService orderProcessingService, OrderBestApplicationTwoStep orderBestApplicationTwo)
  {
    _orderApplicationService = orderProcessingService;
    /*OrderBestApplicationTwoStep orderApplicationTwoStepService*/
    _orderApplicationTwoStepService = orderBestApplicationTwo;
  }


  [HttpPost("two-step")]
  public ActionResult<string> TwoStep([FromBody] OrderRequest request)
  {
    // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":true,"isStockAvailable":true,"isPaymentVerified":true} -> dolandırıcılık şüphesi var, ilk senaryo
    // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":false,"isStockAvailable":false,"isPaymentVerified":true}
    // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":false,"isStockAvailable":true,"isPaymentVerified":false} test case -> limit yetersiz



    _orderApplicationTwoStepService.Submit(request);

    return Ok("");
  }

  
  [HttpPost("three-step")]
    public ActionResult<string> Test([FromBody] OrderRequest request)
    {
        // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":true,"isStockAvailable":true,"isPaymentVerified":true} -> dolandırıcılık şüphesi var, ilk senaryo
        // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":false,"isStockAvailable":false,"isPaymentVerified":true}
        // {"basketCode":"ABC-123","customerNumber":"CS-100","isFraud":false,"isStockAvailable":true,"isPaymentVerified":false} test case -> limit yetersiz

        

    _orderApplicationService.Submit(request);

        return Ok("");
    }
}
