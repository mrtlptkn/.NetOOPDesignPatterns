using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Creational.Singleton;

[ApiController]
[Route("api/singleton")]
public class SingletonController : ControllerBase
{
    [HttpPost("test")]
    public ActionResult<string> Test()
    {
    ConfigManager configManager = ConfigManager.GetInstance();

    return Ok("Singleton örneği: " + configManager.AppName + " v" + configManager.Version);
    }

    [HttpPost("test2")]
    public ActionResult<string> Test2()
    {
        DatabaseConnection dbConn = DatabaseConnection.GetInstance("jdbc://postgres:admin", 10);
        dbConn.Connect();

        return Ok("Singleton örneği: " + dbConn.Url + " maxPoolSize: " + dbConn.MaxPoolSize);
    }
}
