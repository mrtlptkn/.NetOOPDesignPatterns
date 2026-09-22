using System.Globalization;
using System.Text;
using DotNetDesignPatternsApp;
using DotNetDesignPatternsApp.Samples;

// Konsol çıktılarında Türkçe karakterler (ş, ı, ğ ...) bozulmasın.
Console.OutputEncoding = Encoding.UTF8;

// decimal değerler makinenin diline göre "264,000" / "264.000" diye değişmesin
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDesignPatternServices(); // Spring'deki @Component/@Service taramasının karşılığı


// KeyedService Sample
builder.Services.AddKeyedScoped<IPaymentMethod, GiftCardPaymentMethod>(PaymentMethodType.GiftCardMethod);
builder.Services.AddKeyedScoped<IPaymentMethod, CashPaymentMethod>(PaymentMethodType.CachMethod);
builder.Services.AddScoped<PaymentApplicationService>();



var app = builder.Build();

app.UseStaticFiles(); // wwwroot/day1, wwwroot/day2 altındaki diyagram görselleri (Spring'de resources/static)
app.MapControllers();

app.Run();
