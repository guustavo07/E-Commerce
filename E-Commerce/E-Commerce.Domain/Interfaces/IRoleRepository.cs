using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces.Base;

namespace E_Commerce.Domain.Interfaces;
public interface IRoleRepository : IBaseRepository<Role>
{
    Task<Role> GetById(int id);
}
