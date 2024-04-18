using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces.Base;

namespace E_Commerce.Domain.Interfaces;
public interface IBrandRepository : IBaseRepository<Brand>
{
    Task<Brand> GetById(int id);
}
