using E_Commerce.Domain.Entities.Base;

namespace E_Commerce.Domain.Entities;

//classe não pode ser herdada
public sealed class Role : BaseEntity
{
    public string Description { get; set; } = string.Empty;
    public ICollection<User> UsersList { get; }
}
