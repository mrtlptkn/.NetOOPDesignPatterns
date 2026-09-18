namespace DotNetDesignPatternsApp.Structural.Facade;

public class Order
{
    public long? Id { get; set; }
    public string? Code { get; set; }
    public DateOnly ShippedAt { get; set; }
    public DateOnly OrderedAt { get; set; }
    public List<OrderLine> Items { get; set; } = new();
}
