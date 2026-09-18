using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Strategy;

[ApiController]
[Route("api/strategy")]
public class StrategyController : ControllerBase
{
    private readonly CommissionApplication _commissionApplication;

    public StrategyController(CommissionApplication commissionApplication)
    {
        _commissionApplication = commissionApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test([FromBody] CommissionRequest request)
    {
        _commissionApplication.Handle(request);
        return Ok("Commission for " + request.Enterprise);
    }
}
