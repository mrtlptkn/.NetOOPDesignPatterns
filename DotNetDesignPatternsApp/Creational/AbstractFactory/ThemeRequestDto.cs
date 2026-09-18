namespace DotNetDesignPatternsApp.Creational.AbstractFactory;

// Record: init-only çalışır, immutable'dır (set edilemez, getter gibi çalışır).
// Event Driven Programlamada (Event), Web Programlamada (Request/DTO), DDD'de ise ValueObject olarak kullanılır:
//   new Money(100, "$"); new Money(100, "TL");
// ValueObject -> en az 2 parçadan oluşan ve değer olarak birbirinden farklı olan yapılar.
// Class'tan farklı olarak recordlarda Equals ve GetHashCode alanlara göre otomatik üretilir (value-based equality).
// Class'larda ise varsayılan olarak referansa göre karşılaştırılır (reference-based equality).
public record ThemeRequestDto(string ThemeType);
