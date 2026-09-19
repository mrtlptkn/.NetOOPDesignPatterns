using DotNetDesignPatternsApp.Behavioral.Memento.Application;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Behavioral.Memento;

[ApiController]
[Route("api/memento")]
public class MementoController : ControllerBase
{
    private readonly TextEditorApplication _textEditorApplication;

    public MementoController(TextEditorApplication textEditorApplication)
    {
        _textEditorApplication = textEditorApplication;
    }

    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        _textEditorApplication.SimulateEditing();
        return Ok("Memento pattern test successful!");
    }
}
