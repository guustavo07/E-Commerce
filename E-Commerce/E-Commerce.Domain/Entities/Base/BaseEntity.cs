namespace E_Commerce.Domain.Entities.Base;
public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset DateUpdated { get; set;}
}
