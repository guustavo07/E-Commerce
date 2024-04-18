using E_Commerce.Domain.Entities.Base;

namespace E_Commerce.Domain.Entities;

//classe não pode ser herdada
public sealed class Address : BaseEntity
{
    public string Street { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public int Number { get; set; }
    public string State { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public User User { get; set; }

    public ICollection<Order> OrderList { get; }
}
