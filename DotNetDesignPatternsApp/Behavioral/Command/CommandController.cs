using DotNetDesignPatternsApp.Behavioral.Command.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Command;

[ApiController]
[Route("api/command")]
public class CommandController : ControllerBase
{
    private readonly RemoteControllerApplication _commandApplication;

    public CommandController(RemoteControllerApplication commandApplication)
    {
        _commandApplication = commandApplication;
    }

    [HttpPost("open")]
    public ActionResult<string> Open([FromBody] RemoteControlRequest request)
    {
        _commandApplication.Open(request);
        return Ok("Command Design Pattern");
    }

    [HttpPost("close")]
    public ActionResult<string> Close([FromBody] RemoteControlRequest request)
    {
        _commandApplication.Close(request);
        return Ok("Command Design Pattern");
    }
}
