namespace E_Commerce.Application.UseCases.CreateUser;
public sealed record CreateUserResponse
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? Name { get; set; }
    public string Password { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string? Telephone { get; set; } = string.Empty;
    public Guid RoleId { get; set; }

}
