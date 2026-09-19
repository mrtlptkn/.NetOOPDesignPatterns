using DotNetDesignPatternsApp.Behavioral.State.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.State;

[ApiController]
[Route("api/state")]
public class StateController : ControllerBase
{
    private readonly TrafficLightApplication _trafficLightApplication;

    public StateController(TrafficLightApplication trafficLightApplication)
    {
        _trafficLightApplication = trafficLightApplication;
    }

    // Kırmızı ile başladık.
    // {"color":"yellow"}
    // {"color":"green"}
    [HttpPost("test")]
    public ActionResult<string> Test([FromBody] TrafficLightRequest request)
    {
        _trafficLightApplication.Handle(request);
        return Ok("State Design Pattern");
    }
}
