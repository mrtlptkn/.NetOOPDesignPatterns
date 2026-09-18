# DotNetOOPDesignPatterns

[JavaOOPDesignPatterns](https://github.com/mrtlptkn/JavaOOPDesignPatterns) projesinin **.NET 8 / ASP.NET Core Web API** portu.
GoF tasarım desenleri (Creational, Structural, Behavioral) her biri kendi controller'ı ile çalıştırılabilir endpoint olarak sunulur;
desenlerin çıktısı Java sürümündeki gibi **konsola** yazılır.

## Çalıştırma

```bash
dotnet run --project DotNetDesignPatternsApp
```

Uygulama Java sürümündeki gibi `http://localhost:8080` adresinde açılır.
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

## Java → .NET karşılıkları

| Java / Spring Boot | .NET 8 |
|---|---|
| `@RestController` + `@RequestMapping` | `[ApiController]` + `[Route]`, `ControllerBase` |
| `ResponseEntity<String>` | `ActionResult<string>` |
| `@RequestBody` | `[FromBody]` |
| `@Component` / `@Service` | `AddSingleton` (`ServiceCollectionExtensions.cs`) |
| `@Scope("prototype")` | `AddTransient` |
| `@Primary` | interface'in istenen implementasyona yönlendirilmesi |
| `record` | `record` |
| Lombok `@Data` / `@Getter` / `@Setter` | otomatik property'ler / `record` |
| `BigDecimal` | `decimal` |
| `Cloneable` + `super.clone()` | `MemberwiseClone()` |
| Holder idiom (Singleton) | `Lazy<T>` |
| `synchronized` + `volatile` (double-checked locking) | `lock` + `volatile` |
| `default` interface method | default interface method (C# 8+) |
| package-private | `internal` |
| `System.out.println` | `Console.WriteLine` |
| `IllegalArgumentException` / `IllegalStateException` / `UnsupportedOperationException` | `ArgumentException` / `InvalidOperationException` / `NotSupportedException` |
| `src/main/resources/static` | `wwwroot` |
| `application.properties` | `appsettings.json` |
| Interface adları (`Button`, `Transport` ...) | .NET kuralı gereği `I` öneki (`IButton`, `ITransport` ...) |

## Bilinçli farklar

- **Nullable body alanları:** Java'da `Boolean` (nullable) olan request alanları `bool` yapıldı; gönderilmezse `false` kabul edilir.
  `[ApiController]` sayesinde zorunlu `string` alanlar eksikse Java'daki `NullPointerException` (500) yerine **400** döner.
- **Chain of Responsibility:** `PaymentCheckHandler` içinde `passToNext(null)` yerine `PassToNext(orderRequest)` çağrılır
  (zincire yeni bir handler eklenirse `null` ile NRE oluşmaması için; mevcut davranış aynıdır).
- **Facade `Order`:** Java'daki `public Object setOrderedAt;` alanı kullanılmayan artıktı, taşınmadı.
- **Kültür:** `decimal` çıktıları makinenin diline göre değişmesin diye `InvariantCulture` kullanılır (`264.000`, `264,000` değil).
  Konsol çıktısı için UTF-8 ayarlanır (Türkçe karakterler).
- **İsimler:** Java sürümündeki yazım hataları (`FraudCheckHander`, `GreenTraficState`, `IStockMarketSubsciber`, `Recievers` ...)
  eşleştirmesi kolay olsun diye **aynen korundu**.
- **Mediator:** Java deposunda `Mediator.png` görseli var ama Mediator kodu yok; bu yüzden kod olarak taşınmadı, görsel `wwwroot/day2` altında duruyor.
- **Test:** Java'daki tek test boş bir `contextLoads()` idi; taşınmadı.

## Dikkat: thread-safety

Orijinaldeki gibi bazı singleton'lar (`StockMarket`, `TrafficLight`, `BridgeRemoteControllerAllDeviceApplication`,
`CachingDocumentService.Documents`) paylaşılan, kilitsiz mutable durum tutar. Eğitim amaçlı sadeliği korundu;
üretim kodunda `lock` / `ConcurrentDictionary` / `Interlocked` gibi mekanizmalarla korunmalıdır.
