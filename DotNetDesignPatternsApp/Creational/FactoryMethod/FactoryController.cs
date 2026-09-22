using DotNetDesignPatternsApp.Creational.FactoryMethod.Application;
using DotNetDesignPatternsApp.Creational.FactoryMethod.Concretes;
using DotNetDesignPatternsApp.Creational.FactoryMethod.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

[ApiController]
[Route("api/factory")]
public class FactoryController : ControllerBase
{
    [HttpGet("test")]
    public ActionResult<string> Test([FromBody] FactoryMethodRequest request)
    {
        ;

        LogisticsFactory lf = request.factoryType switch
        {
            "RoadLogistics" => new RoadLogisticsFactory(),
            "SeaLogistics" => new SeaLogisticsFactory(),
            "AirLogistics" => new AirlineLogisticsFactory(),
            _ => throw new ArgumentException(
                "Bilinmeyen tip: " + request.factoryType + ". Geçerli değerler: RoadLogistics, SeaLogistics, AirLogistics")
        };

        lf.PlanDelivery();

        return Ok("OK");
    }
}
