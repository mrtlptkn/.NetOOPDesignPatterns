using DotNetDesignPatternsApp.Structural.Composite.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Structural.Composite;

[ApiController]
[Route("api/composite")]
public class CompositeController : ControllerBase
{
    private readonly FileSystemApplication _fileSystemApplication;

    public CompositeController(FileSystemApplication fileSystemApplication)
    {
        _fileSystemApplication = fileSystemApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        _fileSystemApplication.BuildAndDisplay();
        return Ok("Composite pattern test successful!");
    }
}
