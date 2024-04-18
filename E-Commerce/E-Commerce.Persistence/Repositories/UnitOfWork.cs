using E_Commerce.Domain.Interfaces;
using E_Commerce.Persistence.Context;

namespace E_Commerce.Persistence.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}
