using DotNetDesignPatternsApp.Structural.Decorator.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Structural.Decorator;

[ApiController]
[Route("api/decorator")]
public class DecoratorController : ControllerBase
{
    private readonly BeverageApplication _beverageApplication;

    public DecoratorController(BeverageApplication beverageApplication)
    {
        _beverageApplication = beverageApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        _beverageApplication.SubmitBeverage();
        return Ok("Decorator pattern test successful!");
    }
}
