
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class Startup
{

    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }

    public static Assembly GetCoreAssembly(this Assembly assembly)
    {
        return typeof(Startup).Assembly;
    }
}
