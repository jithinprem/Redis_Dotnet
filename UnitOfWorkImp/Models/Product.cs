namespace UnitOfWorkImp.Models;

public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? ProductOrigin { get; set; }
    public int Stock { get; set; }
}