using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces.Base;

namespace E_Commerce.Domain.Interfaces;
public interface IAddressRepository : IBaseRepository<Address>
{
    Task<User> GetById(int id);
}
