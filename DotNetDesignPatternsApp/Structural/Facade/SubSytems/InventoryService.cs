using DotNetDesignPatternsApp.Structural.Facade.Domain;

namespace DotNetDesignPatternsApp.Structural.Facade.SubSytems;

public class InventoryService
{
    private readonly ProductRepository _repository;

    public InventoryService(ProductRepository repository)
    {
        _repository = repository;
    }

    public bool CheckStock()
    {
        Product p = _repository.FindById(1L);
        Console.WriteLine("Stok kontrol ediliyor...");
        return p.Stock > 0;
    }

    public void ReserveStock(int quantity)
    {
        Product p = _repository.FindById(1L);
        p.Stock = p.Stock - quantity;
        Console.WriteLine("Stoktan ayrildi...");
    }
}
