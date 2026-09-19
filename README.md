# DotNetOOPDesignPatterns

Projenin **.NET 8 / ASP.NET Core Web API** portu.
GoF tasarım desenleri (Creational, Structural, Behavioral) her biri kendi controller'ı ile çalıştırılabilir endpoint olarak sunulur;
Desenlerin çıktısı konsola yazdırılır.

## Çalıştırma

```bash
dotnet run --project DotNetDesignPatternsApp
```

Uygulama `http://localhost:8080` adresinde açılır.
Örnek istekler için [`requests.http`](requests.http) dosyasına bakın (VS Code REST Client, Visual Studio, Rider).

Gereksinim: [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0). Harici NuGet paketi kullanılmaz.

## Endpoint'ler

| Desen | Endpoint |
|---|---|
| Abstract Factory | `POST /api/abstract-factory/test` |
| Builder | `POST /api/builder/test`, `POST /api/builder/best` |
| Factory Method | `GET /api/factory/test` |
| Prototype | `POST /api/prototype/test` |
| Singleton | `POST /api/singleton/test`, `POST /api/singleton/test2` |
| Adapter | `POST /api/adapter/pay` |
| Bridge | `POST /api/bridge/open`, `POST /api/bridge/close` |
| Decorator | `POST /api/decorator/test` |
| Facade | `POST /api/facade/test` |
| Proxy | `POST /api/proxy/docs` |
| Chain of Responsibility | `POST /api/chain/test` |
| Command | `POST /api/command/open`, `POST /api/command/close` |
| Observer | `POST /api/observer/updatePrice` |
| State | `POST /api/state/test` |
| Strategy | `POST /api/strategy/test` |

Diyagram görselleri `wwwroot` altındadır, örn. `GET /day2/Command.png`.


