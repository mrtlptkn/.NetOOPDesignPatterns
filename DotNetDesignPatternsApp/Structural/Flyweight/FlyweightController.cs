using DotNetDesignPatternsApp.Structural.Flyweight.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Structural.Flyweight;

[ApiController]
[Route("api/flyweight")]
public class FlyweightController : ControllerBase
{
    private readonly ForestApplication _forestApplication;

    public FlyweightController(ForestApplication forestApplication)
    {
        _forestApplication = forestApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        _forestApplication.PlantForest();
        return Ok("Flyweight pattern test successful!");
    }
}
