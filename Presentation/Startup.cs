using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation;

public static class Startup
{

    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }

    public static Assembly GetPresentationAssembly(this Assembly assembly)
    {
        return typeof(Startup).Assembly;
    }
}
