namespace E_Commerce.Domain.Interfaces;
public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken);
}
