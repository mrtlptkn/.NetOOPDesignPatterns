using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Creational.Prototype;

[ApiController]
[Route("api/prototype")]
public class PrototypeController : ControllerBase
{
    [HttpPost("test")]
    public ActionResult<string> Test()
    {
        var inventory = new List<string>();
        inventory.Add("Katana");

        // g1 heap referansı ile g2 heap referansı aynı referans olsaydı, bir değer değişince aynı referansa
        // baktığından dolayı g2 de değişirdi. Ama doğru copy yaptıysak bundan etkilenmeyiz, yeni bir referans oluşur.
        // g2 ile g1 referansı aynı olmaz.
        var g1 = new GameCharacter("Warrior", 100, 50, inventory);
        GameCharacter g2 = g1.Clone();
        g2.Health = 25;

        return Ok("");
    }
}
