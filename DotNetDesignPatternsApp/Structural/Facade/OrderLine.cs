namespace DotNetDesignPatternsApp.Structural.Facade;

public class OrderLine
{
    public long? OrderId { get; set; }
    public long? ProductId { get; set; }
    public int? Quantity { get; set; }
    public decimal LineTotal { get; set; }
}
