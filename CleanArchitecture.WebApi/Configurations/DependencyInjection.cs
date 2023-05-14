using CleanArchitecture.Application.IRepository;
using CleanArchitecture.Application.Repository;

namespace CleanArchitecture.WebApi.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        return services;
    }
} 