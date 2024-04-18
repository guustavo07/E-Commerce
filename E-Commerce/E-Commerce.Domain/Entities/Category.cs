using E_Commerce.Domain.Entities.Base;

namespace E_Commerce.Domain.Entities;

//classe não pode ser herdada
public sealed class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
