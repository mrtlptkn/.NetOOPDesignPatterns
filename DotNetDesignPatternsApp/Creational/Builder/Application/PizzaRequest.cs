namespace DotNetDesignPatternsApp.Creational.Builder.Application;

// Bu da Application sınıfına son kullanıcının göndermiş olduğu değeri temsil eder.
// Not: Gönderilmeyen bool alanlar false kabul edilir.
public record PizzaRequest(string Size, bool ExtraCheeses, bool ExtraMushrooms, bool ExtraOlives);
