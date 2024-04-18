using E_Commerce.Domain.Entities.Base;

namespace E_Commerce.Domain.Entities;

//classe não pode ser herdada
public sealed class Order : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string? Telephone { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid AddressId { get; set; }
    public Address Address { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }


    public ICollection<Payment> PaymentsList { get; }
}
