using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Startup
{

    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }

    public static Assembly GetInfrastructureAssembly(this Assembly assembly)
    {
        return typeof(Startup).Assembly;
    }
}
