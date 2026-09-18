using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Creational.FactoryMethod;

[ApiController]
[Route("api/factory")]
public class FactoryController : ControllerBase
{
    [HttpGet("test")]
    public ActionResult<string> Test()
    {
        string type = "SeaLogistics";

        LogisticsFactory lf = type switch
        {
            "RoadLogistics" => new RoadLogisticsFactory(),
            "SeaLogistics" => new SeaLogisticsFactory(),
            "AirLogistics" => new AirlineLogisticsFactory(),
            _ => throw new ArgumentException(
                "Bilinmeyen tip: " + type + ". Geçerli değerler: RoadLogistics, SeaLogistics, AirLogistics")
        };

        lf.PlanDelivery();

        return Ok("OK");
    }
}
