using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces.Base;

namespace E_Commerce.Domain.Interfaces;
public interface IPaymentRepository : IBaseRepository<Payment>
{
    Task<Payment> GetById(int id);
}
