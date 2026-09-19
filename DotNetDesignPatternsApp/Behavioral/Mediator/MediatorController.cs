using DotNetDesignPatternsApp.Behavioral.Mediator.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Mediator;

[ApiController]
[Route("api/mediator")]
public class MediatorController : ControllerBase
{
    private readonly ChatApplication _chatApplication;

    public MediatorController(ChatApplication chatApplication)
    {
        _chatApplication = chatApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        _chatApplication.SimulateChat();
        return Ok("Mediator pattern test successful!");
    }
}
