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
| Flyweight | `POST /api/flyweight/test` |
| Composite | `POST /api/composite/test` |
| Memento | `POST /api/memento/test` |
| Template Method | `POST /api/template-method/test` |
| Visitor | `POST /api/visitor/test` |
| Mediator | `POST /api/mediator/test` |

Diyagram görselleri `wwwroot` altındadır, örn. `GET /day2/Command.png`.




## Tasarım desenleri — kısa açıklamalar ve neden kullanılır

- Abstract Factory: Birbirleriyle ilişkili veya bağımlı nesne ailelerini, somut sınıfları belirtmeden
  oluşturmak için kullanılır. Bağımlılığı azaltır ve test edilebilirliği artırır.
- Builder: Karmaşık nesnelerin adım adım ve okunabilir şekilde oluşturulmasını sağlar; immutable/konfigüre
  nesneler için uygundur.
- Factory Method: Alt sınıfların hangi sınıfın örneğini oluşturacağını belirlemesine izin verir;
  nesne oluşturma kodunu kapsüller.
- Prototype: Var olan nesnelerin klonlanarak yeni nesneler oluşturulmasını sağlar; maliyetli oluşturma
  işlemlerinde faydalıdır.
- Singleton: Uygulama boyunca tek örnek olması gereken nesneler için kullanılır (dikkat: thread-safety).
- Adapter: Bir sınıfın arayüzünü istemcinin beklediği başka bir arayüze dönüştürür; dış sistem entegrasyonlarında kullanılır.
- Bridge: Soyutlama ve implementasyonu ayırarak her ikisini bağımsız genişletmeyi sağlar.
- Decorator: Nesnelere dinamik olarak davranış eklemeye yarar; inheritance yerine composition tercih edilir.
- Facade: Karmaşık alt sistemleri basit bir arayüz altında toplar; kullanım kolaylığı sağlar.
- Proxy: Gerçek bir nesneye erişimi kontrol eder; örn. önbellekleme, erişim kontrolü.
- Chain of Responsibility: İstekleri zincire koyulan handler'lar arasında dolaştırarak uygun olanın işlemesini sağlar.
- Command: İstekleri nesne olarak kapsüller; undo/redo, kuyruklama ve loglama için uygundur.
- Observer: Bir nesnenin durum değişikliklerini, abone olan diğer nesnelere bildirir; publish/subscribe benzeri davranış.
- State: Nesnenin iç durumuna göre davranışını değiştirmeye yarar; durum sınıfları arasında geçiş uygular.
- Strategy: Bir algoritma ailesini tanımlar ve bunları birbirinin yerine kullanılabilir hale getirir.
- Flyweight: Çok sayıda benzer nesnenin bellek kullanımını azaltmak için paylaşılan (intrinsic) durumu önbelleğe alır,
  değişen (extrinsic) durumu dışarıda tutar.
- Composite: Nesneleri ağaç yapısında düzenleyip tekil ve bileşik nesneleri (leaf/composite) aynı arayüzle kullanmayı sağlar.
- Memento: Bir nesnenin iç durumunu dışarıya ifşa etmeden saklayıp gerektiğinde geri yüklemeyi sağlar (undo/redo senaryoları).
- Template Method: Bir algoritmanın iskeletini üst sınıfta tanımlar, bazı adımları alt sınıflara bırakarak farklılaştırmayı sağlar.
- Visitor: Nesne yapıları üzerinde yeni işlemler tanımlamayı, nesne sınıflarını değiştirmeden mümkün kılar (double-dispatch).
- Mediator: Nesneler arası doğrudan etkileşimi azaltmak için iletişimi merkezi bir aracı (mediator) üzerinden yapar.

## Dikkat: yaşam döngüleri ve thread-safety

Projedeki servisler .NET DI kullanılarak kayıtlıdır. Genel prensipler:
- Stateless (durum tutmayan) servisler için `Singleton` performanslıdır.
- Per-request state veya DbContext gibi kaynaklar için `Scoped` uygundur.
- Uygulama içi kısa ömürlü işlem ve lokal state tutan servisler için `Transient` tercih edilmelidir.

Bazı örneklerde (ör. `StockMarket`, `TrafficLight`) singleton mutable durum bulunmaktadır; eğitim amaçlı bu davranış korunmuştur.
Üretim kodunda bu tür paylaşılan durumlar için `lock`, `ConcurrentDictionary` veya `Interlocked` gibi eşzamanlılık önlemleri alınmalıdır.


