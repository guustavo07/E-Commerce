using E_Commerce.Domain.Entities;
using E_Commerce.Domain.Interfaces;
using E_Commerce.Persistence.Context;
using E_Commerce.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Persistence.Repositories;
public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context) { }

    public async Task<User> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await Context.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
