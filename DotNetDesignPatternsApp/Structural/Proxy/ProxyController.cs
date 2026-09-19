using DotNetDesignPatternsApp.Structural.Proxy.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Structural.Proxy;

[ApiController]
[Route("api/proxy")]
public class ProxyController : ControllerBase
{
    private readonly DocumentsRequestApplication _application;

    public ProxyController(DocumentsRequestApplication application)
    {
        _application = application;
    }

    [HttpPost("docs")]
    public ActionResult<string> Docs([FromBody] DocumentRequest request)
    {
        _application.Handle(request);

        return Ok("Proxy pattern test endpoint");
    }
}
