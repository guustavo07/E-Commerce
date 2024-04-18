using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces.Base;

namespace E_Commerce.Domain.Interfaces;
public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetById(Guid id, CancellationToken cancellationToken);
}
