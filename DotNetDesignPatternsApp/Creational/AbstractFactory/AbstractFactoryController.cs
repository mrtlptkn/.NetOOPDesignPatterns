using DotNetDesignPatternsApp.Creational.AbstractFactory.Application;
using DotNetDesignPatternsApp.Creational.AbstractFactory.Concretes;
using DotNetDesignPatternsApp.Creational.AbstractFactory.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

[ApiController]
[Route("api/abstract-factory")]
public class AbstractFactoryController : ControllerBase
{
    // Controller sorumluluğu request al ve ver (dto) -> tek satır kod.
    // Separation Of Concerns

    [HttpPost("test")]
    public ActionResult<string> Test([FromBody] ThemeRequestDto dto)
    {
        IUIThemeFactory factory = dto.ThemeType switch
        {
            "LightTheme" => new LightThemeFactory(),
            "DarkTheme" => new DarkThemeFactory(),
            _ => throw new ArgumentException("Bilinmeyen tema tipi: " + dto.ThemeType)
        };

        // Ortak amaç factory sayısı her zaman o factory'nin ürettiği karmaşık ürün sayısından daha az olacaktır.
        // Aslında ürünü üretmek için fabrikasını bilmem yeterli.

        IButton btn = factory.CreateButton();
        btn.Render(); // LightButton Render

        ICheckBox checkBox = factory.CreateCheckBox();
        checkBox.Render(); // LightCheckBox Render

        // IButton btnSample = new DarkButton(); // bunu factory üzerinden otomatik üretiyorum.
        // if (factoryType == "DarkTheme") {
        //     btnSample = new DarkButton();
        // } else if (factoryType == "LightTheme") {
        //     btnSample = new LightButton();
        // }
        // IButton btn2 = factory.CreateButton(); // DarkButton Talebi.
        // btn2.Render(); // DarkButton Render

        return Ok("Abstract Factory pattern test endpoint");
    }
}
