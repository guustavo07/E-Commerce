using E_Commerce.Domain.Interfaces;
using E_Commerce.Persistence.Context;
using E_Commerce.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Persistence;
public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services,
                                                    IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}
