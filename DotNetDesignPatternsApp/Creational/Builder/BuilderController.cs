using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Creational.Builder;

[ApiController]
[Route("api/builder")]
public class BuilderController : ControllerBase
{
    private readonly PizzaApplication _pizzaApplication;

    public BuilderController(PizzaApplication pizzaApplication)
    {
        _pizzaApplication = pizzaApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        Pizza pizza1 = new PizzaBuilderImp("medium")
            .WithExtraCheeses()
            .WithExtraMushrooms()
            .WithExtraOlives()
            .Build();

        Pizza pizza2 = new PizzaBuilderImp("large")
            .WithExtraCheeses()
            .WithExtraMushrooms()
            .Build();

        Pizza pizza3 = new PizzaBuilderImp("small")
            .WithExtraOlives()
            .Build();

        return Ok("Builder pattern test endpoint");
    }

    [HttpPost("best")]
    public ActionResult<string> Best([FromBody] PizzaRequest request)
    {
        // Dinamik olarak bir pizza nesnesi oluşturduk.
        Pizza pizza = _pizzaApplication.Create(request);

        return Ok("Builder pattern test endpoint");
    }
}
