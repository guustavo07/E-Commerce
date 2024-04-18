using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces.Base;

namespace E_Commerce.Domain.Interfaces;
public interface IProductRepository : IBaseRepository<Product>
{
    Task<Product> GetById(int id);
}
