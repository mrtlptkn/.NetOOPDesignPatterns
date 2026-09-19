using DotNetDesignPatternsApp.Behavioral.TemplateMethod.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.TemplateMethod;

[ApiController]
[Route("api/template-method")]
public class TemplateMethodController : ControllerBase
{
    private readonly BeverageApplication _beverageApplication;

    public TemplateMethodController(BeverageApplication beverageApplication)
    {
        _beverageApplication = beverageApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        _beverageApplication.PrepareBeverages();
        return Ok("Template Method pattern test successful!");
    }
}
