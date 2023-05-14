using CleanArchitecture.Domain.Shared;
using CleanArchitecture.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDBContext>(option
            => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        
        services.AddScoped<IApplicationDBContext>(sp
            => sp.GetRequiredService<ApplicationDBContext>());
        
        return services;
    }
}