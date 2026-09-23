using DotNetDesignPatternsApp.Structural.Bridge.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Structural.Bridge;

[ApiController]
[Route("api/bridge")]
public class BridgeController : ControllerBase
{
    private readonly BridgeRemoteControllerAllDeviceApplication _bridgeRemoteControllerApplication;

    public BridgeController(BridgeRemoteControllerAllDeviceApplication bridgeRemoteControllerApplication)
    {
        _bridgeRemoteControllerApplication = bridgeRemoteControllerApplication;
    }

    [HttpPost("open")]
    public ActionResult<string> Open([FromBody] RemoteRequest request)
    {
        _bridgeRemoteControllerApplication.Open(request);

        return Ok("BRIDGE PATTERN - Opened Notification System");
    }

    [HttpPost("close")]
    public ActionResult<string> Close([FromBody] RemoteRequest request)
    {
        _bridgeRemoteControllerApplication.Close(request);

        return Ok("BRIDGE PATTERN - Closed Notification System");
    }
}
