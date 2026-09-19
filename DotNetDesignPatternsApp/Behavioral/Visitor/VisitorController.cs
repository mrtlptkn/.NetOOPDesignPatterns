using DotNetDesignPatternsApp.Behavioral.Visitor.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Visitor;

[ApiController]
[Route("api/visitor")]
public class VisitorController : ControllerBase
{
    private readonly ShoppingCartApplication _shoppingCartApplication;

    public VisitorController(ShoppingCartApplication shoppingCartApplication)
    {
        _shoppingCartApplication = shoppingCartApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        _shoppingCartApplication.CalculateTotal();
        return Ok("Visitor pattern test successful!");
    }
}
