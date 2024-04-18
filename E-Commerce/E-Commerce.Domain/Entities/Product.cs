using E_Commerce.Domain.Entities.Base;

namespace E_Commerce.Domain.Entities;

//classe não pode ser herdada
public sealed class Product : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public float Price { get; set; }
    public int Amount { get; set; }
    public string TechnicalSpec { get; set; } = string.Empty;
    public byte[] Image { get; set; }
    public int Rating { get; set; }
    public Guid CategoryId { get; set; }
    public Guid BrandId { get; set; }

    public ICollection<Order> OrderList { get; }
}
