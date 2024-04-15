using E_Commerce.Domain.Entities.Base;

namespace E_Commerce.Domain.Entities;

//classe não pode ser herdada
public sealed class User : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string? Telephone { get; set; } = string.Empty;
    public Guid RoleId { get; set; }
   //public Role Role {get; set;}
}
