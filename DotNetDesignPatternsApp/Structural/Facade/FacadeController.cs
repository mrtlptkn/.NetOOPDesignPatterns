using DotNetDesignPatternsApp.Structural.Facade.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Structural.Facade;

[ApiController]
[Route("api/facade")]
public class FacadeController : ControllerBase
{
    private readonly OrderFacade _orderFacade;

    public FacadeController(OrderFacade orderFacade)
    {
        _orderFacade = orderFacade;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        // Facade'dan beklentimiz bu.
        _orderFacade.SubmitOrder();
        return Ok("Facade pattern test endpoint");
    }
}
